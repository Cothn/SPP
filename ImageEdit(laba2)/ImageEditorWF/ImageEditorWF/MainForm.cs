using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageEditorWF
{

    public partial class FMain : Form
    {
        public Boolean isPressed;
        public Boolean canDraw;
        public Color currentColor;
        public Point currentLocation;
        public Point previousLocation;
        public FMain()
        {
            InitializeComponent();

            this.AutoScroll = true;


            PBmain.SizeMode = PictureBoxSizeMode.AutoSize;


            isPressed = false;
            canDraw = false;

        }

        private void Bopen_Click(object sender, EventArgs e)
        {

            OpenFileDialog.InitialDirectory = "D:\\";
            OpenFileDialog.Filter = "Bitmap File(*.bmp)|*.bmp|" +
                                    "GIF File(*.gif)|*.gif|" +
                                    "JPEG File(*.jpg)|*.jpg|" +
                                    "TIF File(*.tif)|*.tif|" +
                                    "PNG File(*.png)|*.png";

            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            PBmain.Image = ImageEditor.LoadImage(OpenFileDialog.FileName);
        }

        private void Bsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog.InitialDirectory = "D:\\";
            SaveFileDialog.Filter = "Bitmap File(*.bmp)|*.bmp|" +
                                    "GIF File(*.gif)|*.gif|" +
                                    "JPEG File(*.jpg)|*.jpg|" +
                                    "TIF File(*.tif)|*.tif|" +
                                    "PNG File(*.png)|*.png";

            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;


            if (!ImageEditor.SaveImage(SaveFileDialog.FileName))
                MessageBox.Show("Невозможно сохранить данное изображение!");

        }

        private void TrackBarAngle_Scroll(object sender, EventArgs e)
        {
            PBmain.Image = ImageEditor.NewRotateImage(TrackBarAngle.Value);
        }

        private void TrackBarBrightness_Scroll(object sender, EventArgs e)
        {
            PBmain.Image = ImageEditor.ChangeBrightness(TrackBarBrightness.Value, TrackBarBrightness.Value, TrackBarBrightness.Value);
        }

        private void TrackBarRed_Scroll(object sender, EventArgs e)
        {
            PBmain.Image = ImageEditor.ChangeBrightness(TrackBarRed.Value, 0, 0);
        }

        private void TrackBarGreen_Scroll(object sender, EventArgs e)
        {
            PBmain.Image = ImageEditor.ChangeBrightness(0, TrackBarGreen.Value, 0);
        }

        private void TrackBarBlue_Scroll(object sender, EventArgs e)
        {
            PBmain.Image = ImageEditor.ChangeBrightness(0, 0, TrackBarBlue.Value);
        }

        private void Brefresh_Click(object sender, EventArgs e)
        {
            PBmain.Image = ImageEditor.RefreshImage();
        }

        private void TrackBarSize_Scroll(object sender, EventArgs e)
        {
            PBmain.Image = ImageEditor.ChangeImageSize(TrackBarSize.Value);
        }

        private void Bset_Click(object sender, EventArgs e)
        {
            ImageEditor.ApplyChange();
        }

        private void Bdraw_Click(object sender, EventArgs e)
        {
            canDraw = !canDraw;

            if (canDraw)
                Bdraw.Text = "Stop";
            else
                Bdraw.Text = "Draw";
        }

        private void PBmain_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            currentLocation = e.Location;
        }

        private void PBmain_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void PBmain_MouseMove(object sender, MouseEventArgs e)
        {
            if ((canDraw) && (isPressed))
            {
                previousLocation = currentLocation;
                currentLocation = e.Location;
                PBmain.Image = ImageEditor.DrawOnImage(previousLocation, currentLocation, Color.Black);
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {

        }

        private void PBmain_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
