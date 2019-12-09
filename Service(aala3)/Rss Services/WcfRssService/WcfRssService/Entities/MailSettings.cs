using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfRssService.Entities
{
    public class MailSettings
    {
        private static Dictionary<String, MailSettings> settings = new Dictionary<string, MailSettings>();

        static MailSettings()
        {
            settings.Add("gmail.com", new MailSettings("smtp.gmail.com", 587));
            settings.Add("yandex.ru", new MailSettings("smtp.yandex.ru", 25));
        }
        public MailSettings(String host, Int32 port)
        {
            Host = host;
            Port = port;
        }
        public String Host { get; private set; }
        public Int32 Port { get; private set; }

        static public MailSettings GetSettingsByDomain(String domain)
        {
            MailSettings result;
            if (settings.TryGetValue(domain, out result))
                return result;
            return null;
        }
    }
}