using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfRssService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMailingService" in both code and config file together.
    [ServiceContract]
    public interface IMailingService
    {
        [OperationContract]
        void SendFeedByEmail(String senderEmail, String senderPassword, Dictionary<String, Uri> feed, List<String> tags);
    }
}
