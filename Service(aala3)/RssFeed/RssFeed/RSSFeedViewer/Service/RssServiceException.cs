using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedViewer.Service
{
    public class RssServiceException : Exception
    {
        public RssServiceException(string message) : base(message)
        {
        }

        public RssServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
