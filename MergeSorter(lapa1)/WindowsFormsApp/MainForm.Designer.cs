namespace WindowsFormsApp
{
    partial class MainForm
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelMaxTempFIleSize = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.buttonChooseTempDirectory = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.labelTempDirectory = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.checkBoxAscending = new System.Windows.Forms.CheckBox();
            this.checkBoxSettings = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(83, 3);
            this.trackBar1.Maximum = 50000000;
            this.trackBar1.Minimum = 5000000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(241, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 1000000;
            this.trackBar1.Value = 5000000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelMaxTempFIleSize
            // 
            this.labelMaxTempFIleSize.AutoSize = true;
            this.labelMaxTempFIleSize.Location = new System.Drawing.Point(3, 3);
            this.labelMaxTempFIleSize.Name = "labelMaxTempFIleSize";
            this.labelMaxTempFIleSize.Size = new System.Drawing.Size(71, 13);
            this.labelMaxTempFIleSize.TabIndex = 3;
            this.labelMaxTempFIleSize.Text = "Temp file size";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(86, 2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(81, 25);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Location = new System.Drawing.Point(3, 2);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(81, 25);
            this.buttonChooseFile.TabIndex = 5;
            this.buttonChooseFile.Text = "Choose File";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // buttonChooseTempDirectory
            // 
            this.buttonChooseTempDirectory.Location = new System.Drawing.Point(3, 44);
            this.buttonChooseTempDirectory.Name = "buttonChooseTempDirectory";
            this.buttonChooseTempDirectory.Size = new System.Drawing.Size(74, 50);
            this.buttonChooseTempDirectory.TabIndex = 7;
            this.buttonChooseTempDirectory.Text = "Choose \r\ntemp\r\n directory";
            this.buttonChooseTempDirectory.UseVisualStyleBackColor = true;
            this.buttonChooseTempDirectory.Click += new System.EventHandler(this.buttonChooseTempDirectory_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(3, 28);
            this.textBoxFileName.Multiline = true;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(321, 66);
            this.textBoxFileName.TabIndex = 8;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.labelTempDirectory);
            this.panelSettings.Controls.Add(this.buttonChooseTempDirectory);
            this.panelSettings.Controls.Add(this.labelMaxTempFIleSize);
            this.panelSettings.Controls.Add(this.trackBar1);
            this.panelSettings.Location = new System.Drawing.Point(5, 4);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(327, 100);
            this.panelSettings.TabIndex = 9;
            // 
            // labelTempDirectory
            // 
            this.labelTempDirectory.AutoSize = true;
            this.labelTempDirectory.Location = new System.Drawing.Point(83, 44);
            this.labelTempDirectory.Name = "labelTempDirectory";
            this.labelTempDirectory.Size = new System.Drawing.Size(41, 13);
            this.labelTempDirectory.TabIndex = 8;
            this.labelTempDirectory.Text = "Default";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.checkBoxAscending);
            this.panelMain.Controls.Add(this.buttonChooseFile);
            this.panelMain.Controls.Add(this.textBoxFileName);
            this.panelMain.Controls.Add(this.buttonSort);
            this.panelMain.Location = new System.Drawing.Point(5, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(327, 100);
            this.panelMain.TabIndex = 10;
            // 
            // checkBoxAscending
            // 
            this.checkBoxAscending.AutoSize = true;
            this.checkBoxAscending.Location = new System.Drawing.Point(173, 5);
            this.checkBoxAscending.Name = "checkBoxAscending";
            this.checkBoxAscending.Size = new System.Drawing.Size(76, 17);
            this.checkBoxAscending.TabIndex = 9;
            this.checkBoxAscending.Text = "Ascending";
            this.checkBoxAscending.UseVisualStyleBackColor = true;
            // 
            // checkBoxSettings
            // 
            this.checkBoxSettings.AutoSize = true;
            this.checkBoxSettings.Location = new System.Drawing.Point(8, 104);
            this.checkBoxSettings.Name = "checkBoxSettings";
            this.checkBoxSettings.Size = new System.Drawing.Size(116, 17);
            this.checkBoxSettings.TabIndex = 9;
            this.checkBoxSettings.Text = "Advanced Settings";
            this.checkBoxSettings.UseVisualStyleBackColor = true;
            this.checkBoxSettings.CheckedChanged += new System.EventHandler(this.checkBoxSettings_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 126);
            this.Controls.Add(this.checkBoxSettings);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSettings);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelMaxTempFIleSize;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Button buttonChooseTempDirectory;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.CheckBox checkBoxSettings;
        private System.Windows.Forms.Label labelTempDirectory;
        private System.Windows.Forms.CheckBox checkBoxAscending;
    }
}