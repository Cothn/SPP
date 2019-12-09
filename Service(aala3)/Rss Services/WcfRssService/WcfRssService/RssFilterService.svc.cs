using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfRssService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RssFilterService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RssFilterService.svc or RssFilterService.svc.cs at the Solution Explorer and start debugging.
    public class RssFilterService : IRssFilterService
    {
        public Dictionary<String,Uri> FilterRssFeed(Dictionary<String, Uri> feed, List<String> tags)
        {
            Dictionary<String, Uri> result = new Dictionary<String, Uri>();
            if ((feed != null) && (feed.Count != 0)&&(tags != null) && (tags.Count != 0))
            {
                foreach (var itemTitle in feed.Keys)
                {            
                    foreach (String tag in tags)
                    {
                        if (itemTitle.ToUpper().Contains(tag.ToUpper()))
                        {
                            var itemUrl = feed[itemTitle];
                            result.Add(itemTitle, itemUrl);
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}
