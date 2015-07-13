using System.Drawing;
using System.IO;

namespace ImageProcessor
{
    class ImageData
    {
      public Image img;
      public string filePath;
      public string containingFolder;
      public int imgHeight;
      public int imgWidth;
      public string fileName;

      public ImageData(string file)
      {
          FileInfo inf = new FileInfo(file);
          img = Image.FromFile(file);
          filePath = inf.FullName;
          containingFolder = inf.DirectoryName;
          Bitmap bmp = (Bitmap)img;
          imgHeight = bmp.Height;
          imgWidth = bmp.Width;
          fileName = Path.GetFileNameWithoutExtension(file);
      }
    }
}
