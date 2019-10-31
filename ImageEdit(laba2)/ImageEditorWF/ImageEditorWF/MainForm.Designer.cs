namespace ImageEditorWF
{
    partial class FMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PBmain = new System.Windows.Forms.PictureBox();
            this.Pmain = new System.Windows.Forms.Panel();
            this.TrackBarGreen = new System.Windows.Forms.TrackBar();
            this.TrackBarRed = new System.Windows.Forms.TrackBar();
            this.Bdraw = new System.Windows.Forms.Button();
            this.Bset = new System.Windows.Forms.Button();
            this.TrackBarSize = new System.Windows.Forms.TrackBar();
            this.Brefresh = new System.Windows.Forms.Button();
            this.TrackBarBrightness = new System.Windows.Forms.TrackBar();
            this.TrackBarAngle = new System.Windows.Forms.TrackBar();
            this.Bsave = new System.Windows.Forms.Button();
            this.Bopen = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TrackBarBlue = new System.Windows.Forms.TrackBar();
            this.BlueL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBmain)).BeginInit();
            this.Pmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // PBmain
            // 
            this.PBmain.Location = new System.Drawing.Point(184, 10);
            this.PBmain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBmain.Name = "PBmain";
            this.PBmain.Size = new System.Drawing.Size(479, 435);
            this.PBmain.TabIndex = 0;
            this.PBmain.TabStop = false;
            this.PBmain.Click += new System.EventHandler(this.PBmain_Click);
            this.PBmain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBmain_MouseDown);
            this.PBmain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBmain_MouseMove);
            this.PBmain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PBmain_MouseUp);
            // 
            // Pmain
            // 
            this.Pmain.Controls.Add(this.label6);
            this.Pmain.Controls.Add(this.BlueL);
            this.Pmain.Controls.Add(this.TrackBarBlue);
            this.Pmain.Controls.Add(this.label5);
            this.Pmain.Controls.Add(this.label4);
            this.Pmain.Controls.Add(this.label3);
            this.Pmain.Controls.Add(this.label2);
            this.Pmain.Controls.Add(this.label1);
            this.Pmain.Controls.Add(this.TrackBarGreen);
            this.Pmain.Controls.Add(this.TrackBarRed);
            this.Pmain.Controls.Add(this.Bdraw);
            this.Pmain.Controls.Add(this.Bset);
            this.Pmain.Controls.Add(this.TrackBarSize);
            this.Pmain.Controls.Add(this.Brefresh);
            this.Pmain.Controls.Add(this.TrackBarBrightness);
            this.Pmain.Controls.Add(this.TrackBarAngle);
            this.Pmain.Controls.Add(this.Bsave);
            this.Pmain.Controls.Add(this.Bopen);
            this.Pmain.Location = new System.Drawing.Point(0, 0);
            this.Pmain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pmain.Name = "Pmain";
            this.Pmain.Size = new System.Drawing.Size(180, 445);
            this.Pmain.TabIndex = 1;
            // 
            // TrackBarGreen
            // 
            this.TrackBarGreen.LargeChange = 1;
            this.TrackBarGreen.Location = new System.Drawing.Point(9, 214);
            this.TrackBarGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrackBarGreen.Maximum = 500;
            this.TrackBarGreen.Minimum = 1;
            this.TrackBarGreen.Name = "TrackBarGreen";
            this.TrackBarGreen.Size = new System.Drawing.Size(133, 45);
            this.TrackBarGreen.TabIndex = 9;
            this.TrackBarGreen.Value = 123;
            // 
            // TrackBarRed
            // 
            this.TrackBarRed.LargeChange = 1;
            this.TrackBarRed.Location = new System.Drawing.Point(9, 163);
            this.TrackBarRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrackBarRed.Maximum = 500;
            this.TrackBarRed.Minimum = 1;
            this.TrackBarRed.Name = "TrackBarRed";
            this.TrackBarRed.Size = new System.Drawing.Size(133, 45);
            this.TrackBarRed.TabIndex = 8;
            this.TrackBarRed.Value = 123;
            this.TrackBarRed.Scroll += new System.EventHandler(this.TrackBarRed_Scroll);
            // 
            // Bdraw
            // 
            this.Bdraw.Location = new System.Drawing.Point(11, 40);
            this.Bdraw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bdraw.Name = "Bdraw";
            this.Bdraw.Size = new System.Drawing.Size(131, 19);
            this.Bdraw.TabIndex = 7;
            this.Bdraw.Text = "Draw";
            this.Bdraw.UseVisualStyleBackColor = true;
            this.Bdraw.Click += new System.EventHandler(this.Bdraw_Click);
            // 
            // Bset
            // 
            this.Bset.Location = new System.Drawing.Point(103, 410);
            this.Bset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bset.Name = "Bset";
            this.Bset.Size = new System.Drawing.Size(56, 19);
            this.Bset.TabIndex = 6;
            this.Bset.Text = "Set";
            this.Bset.UseVisualStyleBackColor = true;
            this.Bset.Click += new System.EventHandler(this.Bset_Click);
            // 
            // TrackBarSize
            // 
            this.TrackBarSize.LargeChange = 1;
            this.TrackBarSize.Location = new System.Drawing.Point(11, 328);
            this.TrackBarSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrackBarSize.Maximum = 300;
            this.TrackBarSize.Minimum = 10;
            this.TrackBarSize.Name = "TrackBarSize";
            this.TrackBarSize.Size = new System.Drawing.Size(133, 45);
            this.TrackBarSize.TabIndex = 5;
            this.TrackBarSize.Value = 100;
            this.TrackBarSize.Scroll += new System.EventHandler(this.TrackBarSize_Scroll);
            // 
            // Brefresh
            // 
            this.Brefresh.Location = new System.Drawing.Point(16, 410);
            this.Brefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Brefresh.Name = "Brefresh";
            this.Brefresh.Size = new System.Drawing.Size(56, 19);
            this.Brefresh.TabIndex = 4;
            this.Brefresh.Text = "Refresh";
            this.Brefresh.UseVisualStyleBackColor = true;
            this.Brefresh.Click += new System.EventHandler(this.Brefresh_Click);
            // 
            // TrackBarBrightness
            // 
            this.TrackBarBrightness.LargeChange = 1;
            this.TrackBarBrightness.Location = new System.Drawing.Point(9, 113);
            this.TrackBarBrightness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrackBarBrightness.Maximum = 500;
            this.TrackBarBrightness.Minimum = 1;
            this.TrackBarBrightness.Name = "TrackBarBrightness";
            this.TrackBarBrightness.Size = new System.Drawing.Size(133, 45);
            this.TrackBarBrightness.TabIndex = 3;
            this.TrackBarBrightness.Value = 123;
            this.TrackBarBrightness.Scroll += new System.EventHandler(this.TrackBarBrightness_Scroll);
            // 
            // TrackBarAngle
            // 
            this.TrackBarAngle.LargeChange = 1;
            this.TrackBarAngle.Location = new System.Drawing.Point(9, 63);
            this.TrackBarAngle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrackBarAngle.Maximum = 360;
            this.TrackBarAngle.Name = "TrackBarAngle";
            this.TrackBarAngle.Size = new System.Drawing.Size(133, 45);
            this.TrackBarAngle.TabIndex = 2;
            this.TrackBarAngle.Scroll += new System.EventHandler(this.TrackBarAngle_Scroll);
            // 
            // Bsave
            // 
            this.Bsave.Location = new System.Drawing.Point(81, 0);
            this.Bsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bsave.Name = "Bsave";
            this.Bsave.Size = new System.Drawing.Size(61, 21);
            this.Bsave.TabIndex = 1;
            this.Bsave.Text = "Save Image";
            this.Bsave.UseVisualStyleBackColor = true;
            this.Bsave.Click += new System.EventHandler(this.Bsave_Click);
            // 
            // Bopen
            // 
            this.Bopen.Location = new System.Drawing.Point(2, 0);
            this.Bopen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bopen.Name = "Bopen";
            this.Bopen.Size = new System.Drawing.Size(63, 21);
            this.Bopen.TabIndex = 0;
            this.Bopen.Text = "Open Image";
            this.Bopen.UseVisualStyleBackColor = true;
            this.Bopen.Click += new System.EventHandler(this.Bopen_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Angle";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Brightness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Red";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Green";
            // 
            // TrackBarBlue
            // 
            this.TrackBarBlue.LargeChange = 1;
            this.TrackBarBlue.Location = new System.Drawing.Point(16, 264);
            this.TrackBarBlue.Margin = new System.Windows.Forms.Padding(2);
            this.TrackBarBlue.Maximum = 500;
            this.TrackBarBlue.Minimum = 1;
            this.TrackBarBlue.Name = "TrackBarBlue";
            this.TrackBarBlue.Size = new System.Drawing.Size(133, 45);
            this.TrackBarBlue.TabIndex = 15;
            this.TrackBarBlue.Value = 123;
            // 
            // BlueL
            // 
            this.BlueL.AutoSize = true;
            this.BlueL.Location = new System.Drawing.Point(13, 296);
            this.BlueL.Name = "BlueL";
            this.BlueL.Size = new System.Drawing.Size(28, 13);
            this.BlueL.TabIndex = 16;
            this.BlueL.Text = "Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Size";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 456);
            this.Controls.Add(this.Pmain);
            this.Controls.Add(this.PBmain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBmain)).EndInit();
            this.Pmain.ResumeLayout(false);
            this.Pmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBmain;
        private System.Windows.Forms.Panel Pmain;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button Bsave;
        private System.Windows.Forms.Button Bopen;
        private System.Windows.Forms.TrackBar TrackBarAngle;
        private System.Windows.Forms.TrackBar TrackBarBrightness;
        private System.Windows.Forms.Button Brefresh;
        private System.Windows.Forms.TrackBar TrackBarSize;
        private System.Windows.Forms.Button Bset;
        private System.Windows.Forms.Button Bdraw;
        private System.Windows.Forms.TrackBar TrackBarGreen;
        private System.Windows.Forms.TrackBar TrackBarRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BlueL;
        private System.Windows.Forms.TrackBar TrackBarBlue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

