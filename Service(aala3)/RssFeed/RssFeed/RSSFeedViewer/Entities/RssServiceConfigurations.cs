using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedViewer.Entities
{
    [Serializable]
    public class RssServiceConfigurations
    {
        public List<String> recepients = new List<String>();
        public List<String> tags = new List<String>();
        public List<String> sources = new List<String>();
        public Int32 mailingInterval;
        public String senderEmail;
        public String senderPassword;
    }
}
