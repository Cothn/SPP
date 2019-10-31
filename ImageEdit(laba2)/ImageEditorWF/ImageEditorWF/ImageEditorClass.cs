using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace ImageEditorWF
{
    public static class ImageEditor
    {
        private static Bitmap CurrentImage;
        private static Bitmap ChangedImage;

        public static Bitmap LoadImage(String filePath)
        {
            CurrentImage = new Bitmap(filePath);
            ChangedImage = CurrentImage;

            return CurrentImage;
        }

        public static bool SaveImage(string filePath)
        {
            if (CurrentImage == null)
                return false;

            string fileExtantion = filePath.Remove(0, filePath.Length - 3);

            CurrentImage = ChangedImage;

            try
            {
                switch (fileExtantion)
                {
                    case "bmp":
                        CurrentImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        CurrentImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        CurrentImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        CurrentImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        CurrentImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Bitmap RefreshImage()
        {
            ChangedImage = CurrentImage;
            return CurrentImage;
        }

        public static void ApplyChange()
        {
            CurrentImage = ChangedImage;
        }

        
        /**
        public static Bitmap RotateImage(float angle, Color bkColor)
        {

            if (CurrentImage == null)
                return null;

            angle = angle % 360;
            if (angle > 180)
                angle -= 360;

            PixelFormat pf = default(PixelFormat);
            if (bkColor == Color.Transparent)
            {
                pf = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
            }
            else
            {
                pf = CurrentImage.PixelFormat;
            }

            float sin = (float)Math.Abs(Math.Sin(angle * Math.PI / 180.0)); // this function takes radians
            float cos = (float)Math.Abs(Math.Cos(angle * Math.PI / 180.0)); // this one too
            float newImageWidth = sin * CurrentImage.Height + cos * CurrentImage.Width;
            float newImageHeight = sin * CurrentImage.Width + cos * CurrentImage.Height;
            float originX = 0f;
            float originY = 0f;

            if (angle > 0)
            {
                if (angle <= 90)
                    originX = sin * CurrentImage.Height;
                else
                {
                    originX = newImageWidth;
                    originY = newImageHeight - sin * CurrentImage.Width;
                }
            }
            else
            {
                if (angle >= -90)
                    originY = sin * CurrentImage.Width;
                else
                {
                    originX = newImageWidth - sin * CurrentImage.Height;
                    originY = newImageHeight;
                }
            }

            Bitmap newImage = new Bitmap((int)newImageWidth, (int)newImageHeight, pf);
            Graphics g = Graphics.FromImage(newImage);
            g.Clear(bkColor);
            g.TranslateTransform(originX, originY); // offset the origin to our calculated values
            g.RotateTransform(angle); // set up rotate
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(CurrentImage, 0, 0); // draw the image at 0, 0
            g.Dispose();

            ChangedImage = newImage;

            return newImage;
        }

        */

           
        public static Bitmap NewRotateImage(float angleDegrees)
        {
            Bitmap inputImage = new Bitmap(CurrentImage);

            Color backgroundColor = Color.Transparent;

            // Test for zero rotation and return a clone of the input image
            if (angleDegrees == 0f)
                return (Bitmap)inputImage.Clone();

            // Set up old and new image dimensions
            int oldWidth = inputImage.Width;
            int oldHeight = inputImage.Height;
            int newWidth = oldWidth;
            int newHeight = oldHeight;
            float scaleFactor = 1f;

            //  calculate the size of the resulting bitmap

                double angleRadians = angleDegrees * Math.PI / 180d;

                double cos = Math.Abs(Math.Cos(angleRadians));
                double sin = Math.Abs(Math.Sin(angleRadians));
                newWidth = (int)Math.Round(oldWidth * cos + oldHeight * sin);
                newHeight = (int)Math.Round(oldWidth * sin + oldHeight * cos);



            // Create the new bitmap object. If background color is transparent it must be 32-bit, 
            //  otherwise 24-bit is good enough.
            Bitmap newBitmap = new Bitmap(newWidth, newHeight, backgroundColor == Color.Transparent ?
                                             PixelFormat.Format32bppArgb : PixelFormat.Format24bppRgb);
            newBitmap.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution);

            // Create the Graphics object that does the work
            using (Graphics graphicsObject = Graphics.FromImage(newBitmap))
            {
                graphicsObject.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsObject.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphicsObject.SmoothingMode = SmoothingMode.HighQuality;

                // Fill in the specified background color if necessary
                if (backgroundColor != Color.Transparent)
                    graphicsObject.Clear(backgroundColor);

                // Set up the built-in transformation matrix to do the rotation and maybe scaling
                graphicsObject.TranslateTransform(newWidth / 2f, newHeight / 2f);

                if (scaleFactor != 1f)
                    graphicsObject.ScaleTransform(scaleFactor, scaleFactor);

                graphicsObject.RotateTransform(angleDegrees);
                graphicsObject.TranslateTransform(-oldWidth / 2f, -oldHeight / 2f);

                // Draw the result 
                graphicsObject.DrawImage(inputImage, 0, 0);
            }

            ChangedImage = newBitmap;

            return newBitmap;
        }


        public static Bitmap ChangeBrightness (int redColor, int greenColor, int blueColor)
        {

            if (CurrentImage == null)
                return null;

            var newImage = new Bitmap(CurrentImage);

            ImageAttributes imageAttributes = new ImageAttributes();
            int width = newImage.Width;
            int height = newImage.Height;

            float basicFactor = 0.008F;
            float noChangeFactor = 1F;

            float redColorFactor;
            float greenColorFactor;
            float blueColorFactor;

            if (redColor != 0)
                redColorFactor = basicFactor * redColor;
            else
                redColorFactor = noChangeFactor;

            if (greenColor != 0)
                greenColorFactor = basicFactor * greenColor;
            else
                greenColorFactor = noChangeFactor;

            if (blueColor != 0)
                blueColorFactor = basicFactor * blueColor;
            else
                blueColorFactor = noChangeFactor;

            float[][] colorMatrixElements = {
                                                new float[] {redColorFactor, 0, 0, 0, 0},
                                                new float[] {0, greenColorFactor, 0, 0, 0},
                                                new float[] {0, 0, blueColorFactor, 0, 0},
                                                new float[] {0, 0, 0, 1, 0},
                                                new float[] {0, 0, 0, 0, 1}
                                            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            Graphics graphics = Graphics.FromImage(newImage);
            graphics.DrawImage(newImage, new Rectangle(0, 0, width, height), 0, 0, width,
                               height,
                               GraphicsUnit.Pixel,
                               imageAttributes);

            ChangedImage = newImage;

            return newImage;
        }

        public static Bitmap ChangeImageSize (int zoomFactor)
        {
            if (CurrentImage == null)
                return null;

            if ((CurrentImage.Width < 10) || (CurrentImage.Height < 10))
                    return CurrentImage;

            Size newSize = new Size((int)((CurrentImage.Width * zoomFactor) / 100), (int)((CurrentImage.Height * zoomFactor) / 100));

            ChangedImage = new Bitmap(CurrentImage, newSize);

            return ChangedImage;
        }

        public static Bitmap DrawOnImage(Point drawFrom, Point drawTo, Color color)
        {
            Pen myPen = new Pen(color);
            Graphics myGraph = Graphics.FromImage(ChangedImage);

            myGraph.DrawLine(myPen, drawFrom, drawTo);

            ChangedImage = new Bitmap(ChangedImage);

            return ChangedImage;
        }
    }
}
