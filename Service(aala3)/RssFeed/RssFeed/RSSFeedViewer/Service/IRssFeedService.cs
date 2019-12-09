using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedViewer.Service
{
    public interface IRssFeedService
    {
        Dictionary<String, Uri> LoadFeed(List<String> rssFeedUris);

        Dictionary<String, Uri> FilterFeed(Dictionary<String, Uri> feed, List<String> tags);

        void SendFeedByEmail(String senderEmail, String senderPassword, Dictionary<String, Uri> feed, List<String> tags);
    }
}
