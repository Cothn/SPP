using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfRssService.Entities;

namespace WcfRssService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MailingService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MailingService.svc or MailingService.svc.cs at the Solution Explorer and start debugging.
    public class MailingService : IMailingService
    {
        public void SendFeedByEmail(String senderEmail, String senderPassword, Dictionary<String, Uri> feed, List<String> recepients)
        {
            try
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
                });
            } 
            catch 
            { 
            }
        }

    }
}
