using System;
using System.Drawing;
using System.Threading.Tasks;

namespace ImageFilter
{
    public static class Extensions
    {
        public static Bitmap LinearFilter(this Bitmap source, Func<Color, Color> map)
        {
            var bmp = new LockBitmap(source);
            bmp.LockBits();
            Parallel.For(0, bmp.Height, y => {
                Parallel.For(0, bmp.Width, x => {
                    var input = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, map(input));
                });
            });
            bmp.UnlockBits();
            return source;
        }
    }
}
