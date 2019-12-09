namespace RSSFeedViewer
{
    partial class ConfigurationForm
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
            this.listViewRssSources = new System.Windows.Forms.ListView();
            this.textBoxNewRssSource = new System.Windows.Forms.TextBox();
            this.buttonAddRssSource = new System.Windows.Forms.Button();
            this.buttonAddRecepient = new System.Windows.Forms.Button();
            this.textBoxNewRecepient = new System.Windows.Forms.TextBox();
            this.listViewRecepients = new System.Windows.Forms.ListView();
            this.textBoxNewEmail = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonSaveSenderInfo = new System.Windows.Forms.Button();
            this.buttonAddTag = new System.Windows.Forms.Button();
            this.textBoxNewTag = new System.Windows.Forms.TextBox();
            this.listViewTags = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonDisable = new System.Windows.Forms.RadioButton();
            this.buttonTimerValue = new System.Windows.Forms.Button();
            this.radioButton10min = new System.Windows.Forms.RadioButton();
            this.radioButton1min = new System.Windows.Forms.RadioButton();
            this.radioButton30sec = new System.Windows.Forms.RadioButton();
            this.buttonDeleteSource = new System.Windows.Forms.Button();
            this.buttonDeleteRecepient = new System.Windows.Forms.Button();
            this.buttonTagDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewRssSources
            // 
            this.listViewRssSources.HideSelection = false;
            this.listViewRssSources.Location = new System.Drawing.Point(12, 38);
            this.listViewRssSources.Name = "listViewRssSources";
            this.listViewRssSources.Size = new System.Drawing.Size(448, 104);
            this.listViewRssSources.TabIndex = 0;
            this.listViewRssSources.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxNewRssSource
            // 
            this.textBoxNewRssSource.Location = new System.Drawing.Point(12, 12);
            this.textBoxNewRssSource.Name = "textBoxNewRssSource";
            this.textBoxNewRssSource.Size = new System.Drawing.Size(283, 20);
            this.textBoxNewRssSource.TabIndex = 1;
            // 
            // buttonAddRssSource
            // 
            this.buttonAddRssSource.Location = new System.Drawing.Point(301, 9);
            this.buttonAddRssSource.Name = "buttonAddRssSource";
            this.buttonAddRssSource.Size = new System.Drawing.Size(93, 23);
            this.buttonAddRssSource.TabIndex = 2;
            this.buttonAddRssSource.Text = "Add rss source";
            this.buttonAddRssSource.UseVisualStyleBackColor = true;
            this.buttonAddRssSource.Click += new System.EventHandler(this.buttonAddRssSource_Click);
            // 
            // buttonAddRecepient
            // 
            this.buttonAddRecepient.Location = new System.Drawing.Point(301, 197);
            this.buttonAddRecepient.Name = "buttonAddRecepient";
            this.buttonAddRecepient.Size = new System.Drawing.Size(93, 23);
            this.buttonAddRecepient.TabIndex = 5;
            this.buttonAddRecepient.Text = "Add recipient";
            this.buttonAddRecepient.UseVisualStyleBackColor = true;
            this.buttonAddRecepient.Click += new System.EventHandler(this.buttonAddRecepient_Click);
            // 
            // textBoxNewRecepient
            // 
            this.textBoxNewRecepient.Location = new System.Drawing.Point(12, 200);
            this.textBoxNewRecepient.Name = "textBoxNewRecepient";
            this.textBoxNewRecepient.Size = new System.Drawing.Size(283, 20);
            this.textBoxNewRecepient.TabIndex = 4;
            // 
            // listViewRecepients
            // 
            this.listViewRecepients.HideSelection = false;
            this.listViewRecepients.Location = new System.Drawing.Point(12, 226);
            this.listViewRecepients.Name = "listViewRecepients";
            this.listViewRecepients.Size = new System.Drawing.Size(448, 106);
            this.listViewRecepients.TabIndex = 3;
            this.listViewRecepients.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxNewEmail
            // 
            this.textBoxNewEmail.Location = new System.Drawing.Point(12, 171);
            this.textBoxNewEmail.Name = "textBoxNewEmail";
            this.textBoxNewEmail.Size = new System.Drawing.Size(153, 20);
            this.textBoxNewEmail.TabIndex = 6;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(171, 171);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(170, 20);
            this.textBoxNewPassword.TabIndex = 7;
            // 
            // buttonSaveSenderInfo
            // 
            this.buttonSaveSenderInfo.Location = new System.Drawing.Point(347, 170);
            this.buttonSaveSenderInfo.Name = "buttonSaveSenderInfo";
            this.buttonSaveSenderInfo.Size = new System.Drawing.Size(113, 23);
            this.buttonSaveSenderInfo.TabIndex = 8;
            this.buttonSaveSenderInfo.Text = "Save sender credential";
            this.buttonSaveSenderInfo.UseVisualStyleBackColor = true;
            this.buttonSaveSenderInfo.Click += new System.EventHandler(this.buttonSaveSenderInfo_Click);
            // 
            // buttonAddTag
            // 
            this.buttonAddTag.Location = new System.Drawing.Point(12, 344);
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.Size = new System.Drawing.Size(99, 23);
            this.buttonAddTag.TabIndex = 11;
            this.buttonAddTag.Text = "Add tag";
            this.buttonAddTag.UseVisualStyleBackColor = true;
            this.buttonAddTag.Click += new System.EventHandler(this.buttonAddTag_Click);
            // 
            // textBoxNewTag
            // 
            this.textBoxNewTag.Location = new System.Drawing.Point(12, 373);
            this.textBoxNewTag.Name = "textBoxNewTag";
            this.textBoxNewTag.Size = new System.Drawing.Size(199, 20);
            this.textBoxNewTag.TabIndex = 10;
            // 
            // listViewTags
            // 
            this.listViewTags.HideSelection = false;
            this.listViewTags.Location = new System.Drawing.Point(12, 402);
            this.listViewTags.Name = "listViewTags";
            this.listViewTags.Size = new System.Drawing.Size(199, 90);
            this.listViewTags.TabIndex = 9;
            this.listViewTags.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonDisable);
            this.panel1.Controls.Add(this.buttonTimerValue);
            this.panel1.Controls.Add(this.radioButton10min);
            this.panel1.Controls.Add(this.radioButton1min);
            this.panel1.Controls.Add(this.radioButton30sec);
            this.panel1.Location = new System.Drawing.Point(217, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 132);
            this.panel1.TabIndex = 12;
            // 
            // radioButtonDisable
            // 
            this.radioButtonDisable.AutoSize = true;
            this.radioButtonDisable.Checked = true;
            this.radioButtonDisable.Location = new System.Drawing.Point(13, 42);
            this.radioButtonDisable.Name = "radioButtonDisable";
            this.radioButtonDisable.Size = new System.Drawing.Size(60, 17);
            this.radioButtonDisable.TabIndex = 4;
            this.radioButtonDisable.TabStop = true;
            this.radioButtonDisable.Text = "Disable";
            this.radioButtonDisable.UseVisualStyleBackColor = true;
            // 
            // buttonTimerValue
            // 
            this.buttonTimerValue.Location = new System.Drawing.Point(13, 13);
            this.buttonTimerValue.Name = "buttonTimerValue";
            this.buttonTimerValue.Size = new System.Drawing.Size(216, 23);
            this.buttonTimerValue.TabIndex = 3;
            this.buttonTimerValue.Text = "Change mailing time";
            this.buttonTimerValue.UseVisualStyleBackColor = true;
            this.buttonTimerValue.Click += new System.EventHandler(this.buttonTimerValue_Click);
            // 
            // radioButton10min
            // 
            this.radioButton10min.AutoSize = true;
            this.radioButton10min.Location = new System.Drawing.Point(13, 111);
            this.radioButton10min.Name = "radioButton10min";
            this.radioButton10min.Size = new System.Drawing.Size(76, 17);
            this.radioButton10min.TabIndex = 2;
            this.radioButton10min.TabStop = true;
            this.radioButton10min.Text = "10 minutes";
            this.radioButton10min.UseVisualStyleBackColor = true;
            // 
            // radioButton1min
            // 
            this.radioButton1min.AutoSize = true;
            this.radioButton1min.Location = new System.Drawing.Point(13, 88);
            this.radioButton1min.Name = "radioButton1min";
            this.radioButton1min.Size = new System.Drawing.Size(65, 17);
            this.radioButton1min.TabIndex = 1;
            this.radioButton1min.TabStop = true;
            this.radioButton1min.Text = "1 minute";
            this.radioButton1min.UseVisualStyleBackColor = true;
            // 
            // radioButton30sec
            // 
            this.radioButton30sec.AutoSize = true;
            this.radioButton30sec.Location = new System.Drawing.Point(13, 65);
            this.radioButton30sec.Name = "radioButton30sec";
            this.radioButton30sec.Size = new System.Drawing.Size(80, 17);
            this.radioButton30sec.TabIndex = 0;
            this.radioButton30sec.Text = "30 seconds";
            this.radioButton30sec.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSource
            // 
            this.buttonDeleteSource.Location = new System.Drawing.Point(400, 9);
            this.buttonDeleteSource.Name = "buttonDeleteSource";
            this.buttonDeleteSource.Size = new System.Drawing.Size(60, 23);
            this.buttonDeleteSource.TabIndex = 13;
            this.buttonDeleteSource.Text = "Delete";
            this.buttonDeleteSource.UseVisualStyleBackColor = true;
            this.buttonDeleteSource.Click += new System.EventHandler(this.buttonDeleteSource_Click);
            // 
            // buttonDeleteRecepient
            // 
            this.buttonDeleteRecepient.Location = new System.Drawing.Point(400, 197);
            this.buttonDeleteRecepient.Name = "buttonDeleteRecepient";
            this.buttonDeleteRecepient.Size = new System.Drawing.Size(60, 23);
            this.buttonDeleteRecepient.TabIndex = 14;
            this.buttonDeleteRecepient.Text = "Delete";
            this.buttonDeleteRecepient.UseVisualStyleBackColor = true;
            this.buttonDeleteRecepient.Click += new System.EventHandler(this.buttonDeleteRecepient_Click);
            // 
            // buttonTagDelete
            // 
            this.buttonTagDelete.Location = new System.Drawing.Point(112, 344);
            this.buttonTagDelete.Name = "buttonTagDelete";
            this.buttonTagDelete.Size = new System.Drawing.Size(99, 23);
            this.buttonTagDelete.TabIndex = 15;
            this.buttonTagDelete.Text = "Delete tag";
            this.buttonTagDelete.UseVisualStyleBackColor = true;
            this.buttonTagDelete.Click += new System.EventHandler(this.buttonTagDelete_Click);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 504);
            this.Controls.Add(this.buttonTagDelete);
            this.Controls.Add(this.buttonDeleteRecepient);
            this.Controls.Add(this.buttonDeleteSource);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAddTag);
            this.Controls.Add(this.textBoxNewTag);
            this.Controls.Add(this.listViewTags);
            this.Controls.Add(this.buttonSaveSenderInfo);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxNewEmail);
            this.Controls.Add(this.buttonAddRecepient);
            this.Controls.Add(this.textBoxNewRecepient);
            this.Controls.Add(this.listViewRecepients);
            this.Controls.Add(this.buttonAddRssSource);
            this.Controls.Add(this.textBoxNewRssSource);
            this.Controls.Add(this.listViewRssSources);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRssSources;
        private System.Windows.Forms.TextBox textBoxNewRssSource;
        private System.Windows.Forms.Button buttonAddRssSource;
        private System.Windows.Forms.Button buttonAddRecepient;
        private System.Windows.Forms.TextBox textBoxNewRecepient;
        private System.Windows.Forms.ListView listViewRecepients;
        private System.Windows.Forms.TextBox textBoxNewEmail;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonSaveSenderInfo;
        private System.Windows.Forms.Button buttonAddTag;
        private System.Windows.Forms.TextBox textBoxNewTag;
        private System.Windows.Forms.ListView listViewTags;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonDisable;
        private System.Windows.Forms.Button buttonTimerValue;
        private System.Windows.Forms.RadioButton radioButton10min;
        private System.Windows.Forms.RadioButton radioButton1min;
        private System.Windows.Forms.RadioButton radioButton30sec;
        private System.Windows.Forms.Button buttonDeleteSource;
        private System.Windows.Forms.Button buttonDeleteRecepient;
        private System.Windows.Forms.Button buttonTagDelete;
    }
}