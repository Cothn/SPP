
using RSSFeedViewer.Entities;
using RSSFeedViewer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSSFeedViewer
{
    public partial class RssForm : Form
    {
        private List<SyndicationItem> feeditems = new List<SyndicationItem>();
        private Dictionary<String,Uri> RssFeedItems = new Dictionary<String, Uri>();

        IRssFeedService simpleService = new SimpleService();
        IRssFeedService webService = new WebService();

        IRssFeedService currService;

        private RssServiceConfigurations configs = new RssServiceConfigurations();
        public RssForm()
        {
            InitializeComponent();
            webBrowserMainBrowser.ScriptErrorsSuppressed = true;

            currService = simpleService;

            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col";
            header.Width = 500;

            listViewTitleList.Scrollable = true;
            listViewTitleList.View = View.Details;
            listViewTitleList.Columns.Add(header);

            if (File.Exists("config.bin"))
            {

                BinaryFormatter binFormat = new BinaryFormatter();
                using (Stream fStream = new FileStream("config.bin",FileMode.OpenOrCreate))
                {
                    try
                    {
                        configs = (RssServiceConfigurations)binFormat.Deserialize(fStream);
                    }
                    catch
                    {
                        configs = new RssServiceConfigurations();
                    }
                }
            }


            if (configs.mailingInterval != 0)
            {
                timerMailingTimer.Interval = configs.mailingInterval * 1000;
                timerMailingTimer.Enabled = true;
            }
        }

        private void UpdateFeedTitleList()
        {
            listViewTitleList.Items.Clear();
            foreach (String title in RssFeedItems.Keys)
            {
                listViewTitleList.Items.Add(title);
            }
        }

        private void listViewTitleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTitleList.SelectedIndices.Count != 0)
            {
                Int32 selectedItemIndex = listViewTitleList.SelectedIndices[0];
                Uri feedItem;
                if(RssFeedItems.TryGetValue(listViewTitleList.SelectedItems[0].Text,out feedItem))
                    webBrowserMainBrowser.Url = feedItem;

            }
        }

        private void RssForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfigureService_Click(object sender, EventArgs e)
        {
            timerMailingTimer.Enabled = false;

            ConfigurationForm configurationForm = new ConfigurationForm(configs);
            configurationForm.ShowDialog();

            if (configs.mailingInterval != 0)
            {
                timerMailingTimer.Interval = configs.mailingInterval * 1000;
                timerMailingTimer.Enabled = true;
            }
        }

        private void buttonUpdateFeed_Click(object sender, EventArgs e)
        {
            if (configs.sources.Count != 0)
            {
                IRssFeedService service = currService;


                try
                {
                    RssFeedItems = service.LoadFeed(configs.sources);

                    if (configs.tags.Count != 0)
                        RssFeedItems = service.FilterFeed(RssFeedItems, configs.tags);

                    UpdateFeedTitleList();
                }
                catch (RssServiceException)
                {
                    MessageBox.Show("Error occured. Check your internet connection");
                }
            }
        }

        private void RssForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("config.bin", FileMode.OpenOrCreate))
            {
                try
                {
                    binFormat.Serialize(fStream, configs);
                }
                catch
                {
                }
            }
        }

        private void timerMailingTimer_Tick(object sender, EventArgs e)
        {
            if (configs.sources.Count != 0)
            {
                IRssFeedService service = currService;

                try
                {
                    var feed = service.LoadFeed(configs.sources);

                    if (configs.tags.Count != 0)
                        feed = service.FilterFeed(feed, configs.tags);

                    if ((!String.IsNullOrEmpty(configs.senderEmail)) && (!String.IsNullOrEmpty(configs.senderPassword)) && (feed.Count != 0) && (configs.recepients.Count != 0))
                        service.SendFeedByEmail(configs.senderEmail, configs.senderPassword, feed, configs.recepients);
                }
                catch (RssServiceException)
                {
                    MessageBox.Show("Error occured. Check your internet connection");
                }

              
            }
        }

        private void checkBoxUseWebServices_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseWebServices.Checked)
            {
                currService = webService;
            }
            else
            {
                currService = simpleService;
            }
        }
    }
}
