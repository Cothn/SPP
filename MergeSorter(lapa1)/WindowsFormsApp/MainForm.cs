using MergeSortLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private String tempPath = @"D:/Temp";
        private Int64 FileSize = 50_000_000;

        public MainForm()
        {
            InitializeComponent();
            labelMaxTempFIleSize.Text = String.Format("Temp File Size : \n\r {0} byte", trackBar1.Value);
            panelMain.Visible = true;
            panelSettings.Visible = false;
            trackBar1.Minimum = 1_000_000;
            trackBar1.Maximum = 250_000_000;
            trackBar1.TickFrequency = 10_000_000;
            trackBar1.SmallChange = 10_000_000;
            trackBar1.LargeChange = 10_000_000; 
            trackBar1.Value = (Int32)FileSize;
        }

        private void textBoxTempFileSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelMaxTempFIleSize.Text = String.Format("Temp File Size : \n\r {0} byte", trackBar1.Value);
            FileSize = trackBar1.Value;
        }

        private void checkBoxSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSettings.Checked)
            {
                panelSettings.Visible = true;
                panelMain.Visible = false;
            }
            else
            {
                panelMain.Visible = true;
                panelSettings.Visible = false;
            }
        }

        private void buttonChooseTempDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    tempPath = folderBrowserDialog.SelectedPath;
                    labelTempDirectory.Text = tempPath;
                }
            }
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFileName.Text = openFileDialog.FileName;
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFileName.Text))
            {
                MessageBox.Show("Choose file first!!");
            }

            MergeSort mergeSorter = new MergeSort();
            mergeSorter.Sort(textBoxFileName.Text, checkBoxAscending.Checked, FileSize, tempPath);
            MessageBox.Show("Done");
        }
    }   
}
