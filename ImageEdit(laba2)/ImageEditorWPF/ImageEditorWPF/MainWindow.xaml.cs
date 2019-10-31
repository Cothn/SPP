using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageEditorWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MyBitmapEditor.ImageEditor imageEditor = new MyBitmapEditor.ImageEditor();
        public bool canDraw;
        public bool isPressed;
        public System.Drawing.Point previousLocation;
        public System.Drawing.Point currentLocation;

        public MainWindow()
        {
            InitializeComponent();

            canDraw = false;
        }

        private void ButtonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.FileName = "myImageNumber1"; // Default file name
            openFileDialog.Filter = "JPEG File(*.jpg)|*.jpg|" +
                                    "GIF File(*.gif)|*.gif|" +
                                    "Bitmap File(*.bmp)|*.bmp|" +
                                    "TIF File(*.tif)|*.tif|" +
                                    "PNG File(*.png)|*.png";

            // Show open file dialog box
            Nullable<bool> result = openFileDialog.ShowDialog();

            // Process open file dialog box results
            if (result == false)
                return;

            myImage.Source = imageEditor.Bitmap2BitmapImage(imageEditor.LoadImage(openFileDialog.FileName));
            myImage.Width = imageEditor.GetImageWidth();
            myImage.Height = imageEditor.GetImageHeight();
        }

        private void ButtonSaveFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.FileName = "myImageNumber1"; // Default file name
            saveFileDialog.Filter = "JPEG File(*.jpg)|*.jpg|" +
                                    "GIF File(*.gif)|*.gif|" +
                                    "Bitmap File(*.bmp)|*.bmp|" +
                                    "TIF File(*.tif)|*.tif|" +
                                    "PNG File(*.png)|*.png";

            // Show open file dialog box
            bool? result = saveFileDialog.ShowDialog();

            // Process open file dialog box results
            if (result == false)
                return;

            if (!imageEditor.SaveImage(saveFileDialog.FileName))
                MessageBox.Show("Невозможно сохранить данное изображение!");

        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            myScrollViewer.Height = e.NewSize.Height - 10;
            myScrollViewer.Width = e.NewSize.Width - 171;
        }

        private void ButtonSetChange_Click(object sender, RoutedEventArgs e)
        {
            imageEditor.ApplyChange();
        }

        private void ButtonRefreshImage_Click(object sender, RoutedEventArgs e)
        {
            myImage.Source = imageEditor.Bitmap2BitmapImage(imageEditor.RefreshImage());
        }

        private void SliderImageAngle_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myImage.Source = imageEditor.Bitmap2BitmapImage(imageEditor.NewRotateImage(SliderImageAngle.Value));
            myImage.Width = imageEditor.GetImageWidth();
            myImage.Height = imageEditor.GetImageHeight();
        }

        private void SliderBrightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myImage.Source = imageEditor.Bitmap2BitmapImage(imageEditor.ChangeBrightness(SliderBrightness.Value, SliderBrightness.Value, SliderBrightness.Value));
        }

        private void SliderRedColor_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myImage.Source = imageEditor.Bitmap2BitmapImage(imageEditor.ChangeBrightness(SliderRedColor.Value, 0, 0));
        }

        private void SliderGreenColor_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myImage.Source = imageEditor.Bitmap2BitmapImage(imageEditor.ChangeBrightness(0, SliderGreenColor.Value, 0));
        }

        private void SliderBlueColor_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myImage.Source = imageEditor.Bitmap2BitmapImage(imageEditor.ChangeBrightness(0, 0, SliderBlueColor.Value));
        }

        private void SliderImageSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myImage.Source = imageEditor.Bitmap2BitmapImage(imageEditor.ChangeImageSize(SliderImageSize.Value));
            myImage.Width = imageEditor.GetImageWidth();
            myImage.Height = imageEditor.GetImageHeight();
        }

        private void ButtonDraw_Click(object sender, RoutedEventArgs e)
        {
            canDraw = !canDraw;

            if (!canDraw)
                ButtonDraw.Content = "Start to draw";
            else
                ButtonDraw.Content = "Stop to draw";
        }

        private void MyImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isPressed = true;
            Point _currentLocation = e.GetPosition(myImage);
            currentLocation = new System.Drawing.Point(Convert.ToInt32(_currentLocation.X), Convert.ToInt32(_currentLocation.Y));
        }

        private void MyImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isPressed = false;
        }

        private void MyImage_MouseMove(object sender, MouseEventArgs e)
        {
            if ((canDraw) && (isPressed))
            {
                previousLocation = currentLocation;
                Point _currentLocation = e.GetPosition(myImage);
                currentLocation = new System.Drawing.Point(Convert.ToInt32(_currentLocation.X), Convert.ToInt32(_currentLocation.Y));
                myImage.Source = imageEditor.Bitmap2BitmapImage(imageEditor.DrawOnImage(previousLocation, currentLocation, System.Drawing.Color.Black));
            }
        }
    }
}
