using RSSFeedViewer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSFeedViewer
{
    public partial class ConfigurationForm : Form
    {
        private RssServiceConfigurations configs = new RssServiceConfigurations();
        public ConfigurationForm(RssServiceConfigurations configs)
        {

            InitializeComponent();
            this.configs = configs;
        }

        private void FillListView(ListView listView, List<String> sources)
        {
            foreach (String source in sources)
            { 
                listView.Items.Add(source);
            }
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {

            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col";
            header.Width = 440;

            if (!String.IsNullOrWhiteSpace(configs.senderEmail))
            {
                textBoxNewEmail.Text = configs.senderEmail;
            }


            listViewTags.Scrollable = true;
            listViewTags.View = View.Details;
            listViewTags.Columns.Add(header);
            FillListView(listViewTags, configs.tags);

            listViewRecepients.Scrollable = true;
            listViewRecepients.View = View.Details;
            listViewRecepients.Columns.Add((ColumnHeader)header.Clone());
            FillListView(listViewRecepients, configs.recepients);

            listViewRssSources.Scrollable = true;
            listViewRssSources.View = View.Details;
            listViewRssSources.Columns.Add((ColumnHeader)header.Clone());
            FillListView(listViewRssSources, configs.sources);

            switch (configs.mailingInterval)
            {
                case 0:
                    {
                        radioButtonDisable.Checked = true;
                        break;
                    }
                case 30:
                    {
                        radioButton30sec.Checked = true;
                        break;
                    }
                case 60:
                    {
                        radioButton1min.Checked = true;
                        break;
                    }
                case 600:
                    {
                        radioButton10min.Checked = true;
                        break;
                    }
            }

        }


        private void buttonAddRssSource_Click(object sender, EventArgs e)
        {
            configs.sources.Add(textBoxNewRssSource.Text);
            textBoxNewRssSource.Text = "";
            listViewRssSources.Items.Clear();
            FillListView(listViewRssSources, configs.sources);

        }

        private void buttonSaveSenderInfo_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(textBoxNewEmail.Text)) && (!String.IsNullOrWhiteSpace(textBoxNewPassword.Text)))
            {
                configs.senderEmail = textBoxNewEmail.Text;
                configs.senderPassword = textBoxNewPassword.Text;
            }
            else
            {
                MessageBox.Show("Enter full sender credential");
            }
        }

        private void buttonAddRecepient_Click(object sender, EventArgs e)
        {
            configs.recepients.Add(textBoxNewRecepient.Text);
            textBoxNewRecepient.Text = "";
            listViewRecepients.Items.Clear();
            FillListView(listViewRecepients, configs.recepients);
        }

        private void buttonAddTag_Click(object sender, EventArgs e)
        {
            configs.tags.Add(textBoxNewTag.Text);
            textBoxNewTag.Text = "";
            listViewTags.Items.Clear();
            FillListView(listViewTags, configs.tags);
        }

        private void buttonTimerValue_Click(object sender, EventArgs e)
        {
            if (radioButtonDisable.Checked)
            {
                configs.mailingInterval = 0;
            }
            if (radioButton30sec.Checked)
            {
                configs.mailingInterval = 30;
            }
            if (radioButton1min.Checked)
            {
                configs.mailingInterval = 60;
            }
            if (radioButton10min.Checked)
            {
                configs.mailingInterval = 600;
            }

        }

        private void buttonDeleteSource_Click(object sender, EventArgs e)
        {
            if (listViewRssSources.SelectedIndices.Count != 0)
            {
                var indexForDelete = listViewRssSources.SelectedIndices[0];
                var sourceForDelete = listViewRssSources.Items[indexForDelete].Text;
                configs.sources.Remove(sourceForDelete);
                listViewRssSources.Items.Clear();
                FillListView(listViewRssSources, configs.sources);
            }
            else
            {
                MessageBox.Show("Choose item first");
            }
        }

        private void buttonDeleteRecepient_Click(object sender, EventArgs e)
        {
            if (listViewRecepients.SelectedIndices.Count != 0)
            {
                var indexForDelete = listViewRecepients.SelectedIndices[0];
                var sourceForDelete = listViewRecepients.Items[indexForDelete].Text;
                configs.recepients.Remove(sourceForDelete);
                listViewRecepients.Items.Clear();
                FillListView(listViewRecepients, configs.recepients);
            }
            else
            {
                MessageBox.Show("Choose item first");
            }
        }

        private void buttonTagDelete_Click(object sender, EventArgs e)
        {
            if (listViewTags.SelectedIndices.Count != 0)
            {
                var indexForDelete = listViewTags.SelectedIndices[0];
                var sourceForDelete = listViewTags.Items[indexForDelete].Text;
                configs.tags.Remove(sourceForDelete);
                listViewTags.Items.Clear();
                FillListView(listViewTags, configs.tags);
            }
            else
            {
                MessageBox.Show("Choose item first");
            }
        }
    }
}
