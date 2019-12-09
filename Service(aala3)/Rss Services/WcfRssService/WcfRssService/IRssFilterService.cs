using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfRssService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRssFilterService" in both code and config file together.
    [ServiceContract]
    public interface IRssFilterService
    {
        [OperationContract]
        Dictionary<String, Uri> FilterRssFeed(Dictionary<String, Uri> feed, List<String> tags);
    }
}
