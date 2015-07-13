using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ImageProcessor
{
    public partial class ImageTemplate : UserControl
    {
        bool isEntered = false;
        bool isHovered = false;
        Color selectionColor = Color.SkyBlue;
        Color hoverColor = Color.LightGreen;
        string fileName;
        ImageData imgData;
        void SetImage()
        {
            BackgroundImage = Image.FromFile(fileName);
            FixSize();
        }
      
        public Color SelectionColor
        {
            set { selectionColor = value; Invalidate(); }
            get { return selectionColor; }
        }
    
        public Color HoverColor
        {
            set { hoverColor = value; Invalidate(); }
            get { return hoverColor; }
        }

        public bool IsEntered
        {
            get { return isEntered; }
        }

        public ImageTemplate(string imageFilePath)
        {
            InitializeComponent();
            fileName = imageFilePath;
            SetImage();
            imgData = new ImageData(imageFilePath);
        }

        void FixSize()
        {
            Bitmap bmp = (Bitmap)BackgroundImage;
            if (bmp.Height > Height || bmp.Width > Width)
                BackgroundImageLayout = ImageLayout.Zoom;
            else
                BackgroundImageLayout = ImageLayout.Center;
        }

        private void ImageTemplate_Enter(object sender, EventArgs e)
        {
            isEntered = true;
            Invalidate();
        }

        private void ImageTemplate_Leave(object sender, EventArgs e)
        {
            isEntered = false;
            Invalidate();
        }

        private void ImageTemplate_MouseEnter(object sender, EventArgs e)
        {
            isHovered = true;
            Invalidate();
        }

        private void ImageTemplate_MouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            Invalidate();
        }

        private void ImageTemplate_Paint(object sender, PaintEventArgs e)
        {
            if (isHovered)
            {
                Rectangle rec = new Rectangle(1, 1, Width - 2, Height - 2);
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(HoverColor),2), rec);
            }
            if (isEntered)
            {
                Rectangle rec = new Rectangle(1, 1, Width - 2, Height - 2);
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(SelectionColor),2), rec);
            }
        }

        public void Reload()
        {
            SetImage();
        }

        private void ImageTemplate_DoubleClick(object sender, EventArgs e)
        {
            ImageInfo imgInfo = new ImageInfo(imgData);
            imgInfo.ShowDialog();
        }

     

       
    }
}
