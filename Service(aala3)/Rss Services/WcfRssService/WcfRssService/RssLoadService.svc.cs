using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WcfRssService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RssLoadService : IRssService
    {

        object lockMe = new object();

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
                    try
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
                                        result.Add(item.Title.Text, item.Links[0].Uri);
                                    }
                                }
                            }
                        };
                    }
                    catch
                    { 

                    }
                });
            }
            catch
            {

            }

            return result;
        }
    }
}
