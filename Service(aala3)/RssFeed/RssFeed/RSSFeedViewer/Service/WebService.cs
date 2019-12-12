using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedViewer.Service
{
    public class WebService : IRssFeedService
    {
        public Dictionary<String, Uri> LoadFeed(List<String> rssFeedUris)
        {
            var result = new Dictionary<String, Uri>();
            try
            {
                using (RssLoadService.RssServiceClient client = new RssLoadService.RssServiceClient())
                //using (RssLoadService.IRssService client = new RssLoadService.RssServiceClient())
                {

                    result = client.LoadFeed(rssFeedUris.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new RssServiceException(ex.Message);
            }

            return result;
        }

        public Dictionary<String, Uri> FilterFeed(Dictionary<String, Uri> feed, List<String> tags)
        {
            var result = new Dictionary<String, Uri>();
            try
            {
                using (RssFilterService.RssFilterServiceClient client = new RssFilterService.RssFilterServiceClient())
                {
                    result = client.FilterRssFeed(feed, tags.ToArray());
                }
            }
            catch (Exception ex)
            {
                //throw new RssServiceException(ex.Message);
            }

            return result;
        }

        public void SendFeedByEmail(String senderEmail, String senderPassword, Dictionary<String, Uri> feed, List<String> recepients)
        {
            try
            {
                using (MailingService.MailingServiceClient client = new MailingService.MailingServiceClient())
                {
                    client.SendFeedByEmail(senderEmail, senderPassword, feed, recepients.ToArray());
                }
            }
            catch (Exception ex)
            {
                //throw new RssServiceException(ex.Message);
            }
        }
    }
}
