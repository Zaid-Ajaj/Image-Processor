using System.Drawing;
using System.Threading.Tasks;
using static System.Math;

namespace ImageFilter
{
    // filters a bitmap 
    public class Filter
    {
        public static Bitmap GrayScale(Bitmap source) => 
            source.LinearFilter(input => {
                var avg = (input.R + input.G + input.B)/3;
                return Color.FromArgb(avg, avg, avg);
            });

        public static Bitmap Invert(Bitmap source) =>
            source.LinearFilter(input => {
                return Color.FromArgb(255 - input.R, 255 - input.G, 255 - input.B);
            });

        public static Bitmap SepiaTone(Bitmap source) =>
            source.LinearFilter(input => {
                var red = (int)(input.R * 0.462);
                var green = (int)(input.G * 0.193);
                var blue = (int)(input.B * 0.1083);
                return Color.FromArgb(red, green, blue);
            });

        public static Bitmap BrighterImage(Bitmap source, int val) =>
            source.LinearFilter(input => {
                var red = Min(255, input.R + val);
                var green = Min(255, input.G + val);
                var blue = Min(255, input.B + val);
                return Color.FromArgb(red, green, blue);
            });

        public static Bitmap DarkerImage(Bitmap source, int val) =>
            source.LinearFilter(input => {
                var red = Max(0, input.R - val);
                var green = Max(0, input.G - val);
                var blue = Max(0, input.B - val);
                return Color.FromArgb(red, green, blue);
            });

        public static Bitmap DetectEdges(Bitmap source, int threshold)
        {
            var input = new LockBitmap(source);
            var output = new Bitmap(source.Width, source.Height);
            var bmpOutput = new LockBitmap(output);
            input.LockBits();
            bmpOutput.LockBits();
            Parallel.For(1, input.Height - 1, y =>
            {
                Parallel.For(1, input.Width - 1, x =>
                {
                    var nextY = input.GetPixel(x, y + 1);
                    var prevY = input.GetPixel(x, y - 1);
                    var nextX = input.GetPixel(x + 1, y);
                    var prevX = input.GetPixel(x - 1, y);
                    int xRed = nextX.R - prevX.R;
                    int yRed = nextY.R - prevY.R;
                    double result = Min(0.5 * Sqrt(xRed * xRed  + yRed * yRed), 255);
                    if (threshold > result)
                        bmpOutput.SetPixel(x, y, Color.White);
                    else
                        bmpOutput.SetPixel(x, y, Color.Black);
                });
            });
            bmpOutput.UnlockBits();
            input.UnlockBits();
            return output;
        }


    }
}
