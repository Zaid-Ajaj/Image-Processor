using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class ImageInfo : Form
    {
        public ImageInfo(object obj)
        {
            ImageData imgData = (ImageData)obj;
            InitializeComponent();
            txtDimensions.Text = imgData.imgHeight.ToString() + " * " + imgData.imgWidth + " (Height * Width)";
            txtFileName.Text = imgData.fileName;
            txtFullPath.Text = imgData.filePath;
            txtContaningFolder.Text = imgData.containingFolder;
            pic.Image = imgData.img;

            // Fixing Size

            Bitmap bmp = (Bitmap)pic.Image;
            if (bmp.Width > pic.Width || bmp.Height > pic.Height)
                pic.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pic.SizeMode = PictureBoxSizeMode.CenterImage;
            Text = "Image Information - " + imgData.fileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txtContaningFolder.Text);
            }
            catch
            {
                MessageBox.Show("We have encountered an unknown error while opening the contaning folder of the selected image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
