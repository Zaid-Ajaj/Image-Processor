using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace ImageProcessor
{
    class Filter
    {
        public static Bitmap GrayScale(Image original)
        {
            Bitmap bmp = (Bitmap)original;
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)(void*)bmpData.Scan0;
                for (int i = 0; i < bmp.Height; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        p[0] = p[1] = p[2] = (byte)(p[0] * .299 + p[1] * .578 + p[2] * .114);
                        p += 3;
                    }
                    p += bmpData.Stride - bmp.Width * 3;
                }
            }
            bmp.UnlockBits(bmpData);
            return bmp;
        }

        public static Bitmap Invert(Image original)
        {
            Bitmap bmp = (Bitmap)original;
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)(void*)bmpData.Scan0;
                for (int i = 0; i < bmp.Height; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        p[0] = (byte)(255 - p[0]);
                        p[1] = (byte)(255 - p[1]);
                        p[2] = (byte)(255 - p[2]);
                        p += 3;
                    }
                    p += bmpData.Stride - bmp.Width * 3;
                }
            }
            bmp.UnlockBits(bmpData);
            return bmp;
        }

        public static Bitmap SepiaTone(Image original)
        {
            Bitmap bmp = (Bitmap)original;
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)(void*)bmpData.Scan0;
                for (int i = 0; i < bmp.Height; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        p[0] = p[1] = p[2] = (byte)(p[0] * .299 + p[1] * .578 + p[0] * .114);
                        p[2] = (byte)(p[2] * .95);
                        p[1] = (byte)(p[1] * .80);
                        p[0] = (byte)(p[0] * .60);
                        p += 3;
                    }
                    p += bmpData.Stride - bmp.Width * 3;
                }
            }
            bmp.UnlockBits(bmpData);
            return bmp;
        }

        public static Bitmap BrighterImage(Image original, int val)
        {
            Bitmap bmp = (Bitmap)original;
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)(void*)bmpData.Scan0;
                for (int i = 0; i < bmp.Height; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        int nRed = p[0] + val;
                        int nGreen = p[1] + val;
                        int nBlue = p[2] + val;
                        if (nRed > 255) nRed = 255;
                        if (nGreen > 255) nGreen = 255;
                        if (nBlue > 255) nBlue = 255;
                        p[0] = (byte)nRed;
                        p[1] = (byte)nGreen;
                        p[2] = (byte)nBlue;
                        p += 3;
                    }
                    p += bmpData.Stride - bmp.Width * 3;
                }
            }
            bmp.UnlockBits(bmpData);
            return bmp;
        }

        public static Bitmap DarkerImage(Image original, int val)
        {
            Bitmap bmp = (Bitmap)original;
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)(void*)bmpData.Scan0;
                for (int i = 0; i < bmp.Height; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        int nRed = p[0] - val;
                        int nGreen = p[1] - val;
                        int nBlue = p[2] - val;
                        if (nRed < 0) nRed = 0;
                        if (nGreen < 0) nGreen = 0;
                        if (nBlue < 0) nBlue = 0;
                        p[0] = (byte)nRed;
                        p[1] = (byte)nGreen;
                        p[2] = (byte)nBlue;
                        p += 3;
                    }
                    p += bmpData.Stride - bmp.Width * 3;
                }
            }
            bmp.UnlockBits(bmpData);
            return bmp;
        }

        public static Bitmap DetectEdges(Image original, int condition)
        {
            Bitmap bmp = (Bitmap)original;
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            Color[,] colorData = new Color[bmp.Height, bmp.Width];
            unsafe
            {
                byte* p = (byte*)(void*)bmpData.Scan0;
                for (int i = 0; i < bmp.Height; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        colorData[i, j] = Color.FromArgb(p[0], p[1], p[2]);
                        p += 3;
                    }
                    p += bmpData.Stride - bmp.Width * 3;
                }
                p = (byte*)(void*)bmpData.Scan0;
                for (int i = 1; i < bmp.Height -1; i++)
                {
                    p[2] = p[1] = p[0] = 255;
                    p += 3;
                    p[2] = p[1] = p[0] = 255;
                    p += 3;
                    for (int j = 1; j < bmp.Width - 1; j++)
                    {
                        Color nextY = colorData[i + 1, j];
                        Color prevY = colorData[i - 1, j];
                        Color nextX = colorData[i, j + 1];
                        Color prevX = colorData[i, j - 1];
                        int xRed = nextX.R - prevX.R;
                        int yRed = nextY.R - prevY.R;
                        double eqResault = Math.Min(Math.Sqrt(xRed * xRed / 4 + yRed * yRed / 4), 255);
                        if (condition > eqResault)
                            p[2] = p[1] = p[0] = 255;
                        else
                            p[2] = p[1] = p[0] = 0;
                        p += 3;
                    }
                    p += bmpData.Stride - bmp.Width * 3;
                }
            }
            bmp.UnlockBits(bmpData);
            return bmp;
        }

    }
}
