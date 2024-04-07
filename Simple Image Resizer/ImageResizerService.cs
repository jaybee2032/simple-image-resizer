using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Image_Resizer
{
    class ImageResizerService
    {
        public static async Task ResizeImageAsync(string inputImagePath, string outputImagePath, int newWidth, int newHeight)
        {
            await Task.Run(() =>
            {
                // Load the image from file
                using (Image inputImage = Image.FromFile(inputImagePath))
                {
                    // Create a new bitmap with the desired dimensions
                    using (Bitmap resizedBitmap = new Bitmap(newWidth, newHeight))
                    {
                        // Create a Graphics object from the new bitmap
                        using (Graphics graphics = Graphics.FromImage(resizedBitmap))
                        {
                            // Clear the graphics with a transparent background
                            graphics.Clear(Color.Transparent);

                            // Set the interpolation mode to HighQualityBicubic for better image quality
                            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                            // Draw the input image onto the new bitmap with the desired dimensions
                            graphics.DrawImage(inputImage, 0, 0, newWidth, newHeight);

                            graphics.RotateTransform(90);

                            // Save the resized image to the specified output path with JPEG format and compression quality of 100%
                            resizedBitmap.Save(outputImagePath, ImageFormat.Jpeg);
                        }
                    }
                }
            });
        }
    }
}
/*
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

class Program
{



}
 


 */