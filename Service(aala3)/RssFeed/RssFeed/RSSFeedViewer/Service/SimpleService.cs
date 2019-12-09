using RSSFeedViewer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RSSFeedViewer.Service
{
    public class SimpleService : IRssFeedService
    {
        Object lockMe = new Object();
        Object filterLockMe = new Object();

        public Dictionary<String, Uri> LoadFeed(List<String> rssFeedUris)
        {
            var result = new Dictionary<String, Uri>();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            SyndicationFeed syndicationFeed = null;
            try
            {
                Parallel.ForEach(rssFeedUris, (rssFeedUri) =>
                {
                    using (XmlReader xmlReader = XmlReader.Create(rssFeedUri, settings))
                    {
                        syndicationFeed = SyndicationFeed.Load(xmlReader);
                        foreach (var item in syndicationFeed.Items)
                        {
                            if ((item.Links.Count != 0) && (item.Links[0].Uri != null))
                            {
                                lock (lockMe)
                                {
                                    if(!result.ContainsKey(item.Title.Text.Trim()))
                                        result.Add(item.Title.Text.Trim(), item.Links[0].Uri);
                                }
                            }
                        }
                    };
                });
            }
            catch(Exception ex)
            {
                throw new RssServiceException(ex.Message);
            }

            return result;
        }


        public Dictionary<String, Uri> FilterFeed(Dictionary<String, Uri> feed, List<String> tags)
        {

            Dictionary<String, Uri> result = new Dictionary<String, Uri>();
            try
            {
                if ((feed != null) && (feed.Count != 0) && (tags != null) && (tags.Count != 0))
                {
                    Parallel.ForEach(feed.Keys, (title) =>
                     {
                        //foreach (var itemTitle in feed.Keys)
                        //{
                        foreach (String tag in tags)
                         {
                             if (title.ToUpper().Contains(tag.ToUpper()))
                             {
                                 var itemUrl = feed[title];
                                 lock (filterLockMe)
                                 {
                                     if (!result.ContainsKey(title.Trim()))
                                         result.Add(title, itemUrl);
                                 }
                                 break;
                             }
                         }
                        //}
                    });
                }
            }
            catch(Exception ex) 
            {
                throw new RssServiceException(ex.Message);
            }

            return result;
        }

        public void SendFeedByEmail(String senderEmail, String senderPassword, Dictionary<String, Uri> feed, List<String> recepients)
        {

            var fromAddress = new MailAddress(senderEmail, "Rss feed delivery");
            MailSettings settings = MailSettings.GetSettingsByDomain(senderEmail.Split('@')[1]);
            string fromPassword = senderPassword;
            string subject = "Rss feed";
            string body = String.Empty;
            foreach (var news in feed)
            {
                body += news.Key + " " + news.Value.ToString() + '\n';
            }

            Parallel.ForEach(recepients, (recepient) =>
             {
                 try
                 {
                     var smtp = new SmtpClient
                     {
                         Host = settings.Host,
                         Port = settings.Port,
                         EnableSsl = true,
                         DeliveryMethod = SmtpDeliveryMethod.Network,
                         UseDefaultCredentials = false,
                         Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                         Timeout = 20000
                     };
                     using (var message = new MailMessage(fromAddress, new MailAddress(recepient, "")) { Subject = subject, Body = body })
                     {
                         smtp.Send(message);
                     }
                 }
                 catch (Exception ex)
                 {
                     
                 }
             });
        }
    }
}
