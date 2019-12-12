namespace RSSFeedViewer
{
    partial class RssForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowserMainBrowser = new System.Windows.Forms.WebBrowser();
            this.listViewTitleList = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBoxUseWebServices = new System.Windows.Forms.CheckBox();
            this.buttonUpdateFeed = new System.Windows.Forms.Button();
            this.buttonConfigureService = new System.Windows.Forms.Button();
            this.timerMailingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserMainBrowser
            // 
            this.webBrowserMainBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserMainBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowserMainBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMainBrowser.Name = "webBrowserMainBrowser";
            this.webBrowserMainBrowser.Size = new System.Drawing.Size(788, 669);
            this.webBrowserMainBrowser.TabIndex = 0;
            // 
            // listViewTitleList
            // 
            this.listViewTitleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTitleList.BackColor = System.Drawing.Color.RosyBrown;
            this.listViewTitleList.ForeColor = System.Drawing.Color.Chocolate;
            this.listViewTitleList.HideSelection = false;
            this.listViewTitleList.Location = new System.Drawing.Point(3, 127);
            this.listViewTitleList.Name = "listViewTitleList";
            this.listViewTitleList.Size = new System.Drawing.Size(393, 548);
            this.listViewTitleList.TabIndex = 1;
            this.listViewTitleList.UseCompatibleStateImageBehavior = false;
            this.listViewTitleList.View = System.Windows.Forms.View.List;
            this.listViewTitleList.SelectedIndexChanged += new System.EventHandler(this.listViewTitleList_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxUseWebServices);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdateFeed);
            this.splitContainer1.Panel1.Controls.Add(this.buttonConfigureService);
            this.splitContainer1.Panel1.Controls.Add(this.listViewTitleList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserMainBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(1197, 675);
            this.splitContainer1.SplitterDistance = 399;
            this.splitContainer1.TabIndex = 5;
            // 
            // checkBoxUseWebServices
            // 
            this.checkBoxUseWebServices.AutoSize = true;
            this.checkBoxUseWebServices.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxUseWebServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBoxUseWebServices.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUseWebServices.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBoxUseWebServices.Location = new System.Drawing.Point(11, 94);
            this.checkBoxUseWebServices.Name = "checkBoxUseWebServices";
            this.checkBoxUseWebServices.Size = new System.Drawing.Size(105, 20);
            this.checkBoxUseWebServices.TabIndex = 5;
            this.checkBoxUseWebServices.Text = "Use web services";
            this.checkBoxUseWebServices.UseVisualStyleBackColor = false;
            this.checkBoxUseWebServices.CheckedChanged += new System.EventHandler(this.checkBoxUseWebServices_CheckedChanged);
            // 
            // buttonUpdateFeed
            // 
            this.buttonUpdateFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateFeed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonUpdateFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateFeed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdateFeed.Location = new System.Drawing.Point(3, 53);
            this.buttonUpdateFeed.Name = "buttonUpdateFeed";
            this.buttonUpdateFeed.Size = new System.Drawing.Size(393, 35);
            this.buttonUpdateFeed.TabIndex = 4;
            this.buttonUpdateFeed.Text = "Update";
            this.buttonUpdateFeed.UseVisualStyleBackColor = false;
            this.buttonUpdateFeed.Click += new System.EventHandler(this.buttonUpdateFeed_Click);
            // 
            // buttonConfigureService
            // 
            this.buttonConfigureService.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonConfigureService.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfigureService.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonConfigureService.Location = new System.Drawing.Point(3, 10);
            this.buttonConfigureService.Name = "buttonConfigureService";
            this.buttonConfigureService.Size = new System.Drawing.Size(393, 37);
            this.buttonConfigureService.TabIndex = 3;
            this.buttonConfigureService.Text = "Configure service";
            this.buttonConfigureService.UseVisualStyleBackColor = false;
            this.buttonConfigureService.Click += new System.EventHandler(this.buttonConfigureService_Click);
            // 
            // timerMailingTimer
            // 
            this.timerMailingTimer.Tick += new System.EventHandler(this.timerMailingTimer_Tick);
            // 
            // RssForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 682);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RssForm";
            this.Text = "Rss Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RssForm_FormClosed);
            this.Load += new System.EventHandler(this.RssForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserMainBrowser;
        private System.Windows.Forms.ListView listViewTitleList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonUpdateFeed;
        private System.Windows.Forms.Button buttonConfigureService;
        private System.Windows.Forms.Timer timerMailingTimer;
        private System.Windows.Forms.CheckBox checkBoxUseWebServices;
    }
}