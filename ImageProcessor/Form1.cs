using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace ImageProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, Width, toolStrip1.Height);
            LinearGradientBrush lgb = new LinearGradientBrush(rec, Color.LightGreen, Color.SkyBlue, LinearGradientMode.BackwardDiagonal);
            e.Graphics.FillRectangle(lgb, rec);
        }

        void FixSize()
        {
            Bitmap bmp = (Bitmap)pic.Image;
            if (bmp.Width > pic.Width || bmp.Height > pic.Height)
                pic.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pic.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void imagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string str = ofd.FileName;
                if (str.EndsWith(".jpg") || str.EndsWith(".JPG") || str.EndsWith(".bmp") || str.EndsWith(".png") || str.EndsWith(".gif"))
                { pic.Image = Image.FromFile(str); FixSize(); pnl.Visible = false; pic.Tag = str; }
                else
                    MessageBox.Show("Unknown file format, available file formats : *.jpg | *.png | *.bmp and *.gif", "Error Opening Selected File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void wholeFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnl.Controls.Clear();
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                Cursor = Cursors.WaitCursor;
                int startY = 8;
                pnl.Visible = true;
                foreach (string file in files)
                {
                    if (file.EndsWith(".jpg") || file.EndsWith(".bmp") || file.EndsWith(".png") || file.EndsWith(".JPG") || file.EndsWith(".gif"))
                    {
                        if (File.Exists(file))
                        {
                            try
                            {
                                ImageTemplate img = new ImageTemplate(file);
                                img.Location = new Point(0, startY);
                                img.Click += new EventHandler(delegate { pic.Image = img.BackgroundImage; FixSize(); pic.Tag = img; });
                                pnl.Controls.Add(img);
                                startY += img.Height + 10;
                            }
                            catch {  }
                        }
                         
                    }
                }
                Cursor = Cursors.Default;  
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic.Image != null)
            {
                Cursor = Cursors.WaitCursor;
                pic.Image = Filter.GrayScale(pic.Image);
                Cursor = Cursors.Default;
                foreach (ImageTemplate img in pnl.Controls)
                {
                    if (pic.Tag.GetType() == typeof(ImageTemplate) && (ImageTemplate)pic.Tag == img)
                    {
                        img.Reload();
                    }
                }
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic.Image != null)
            {
                if (pic.Tag.GetType() == typeof(string))
                {
                    pic.Image = Image.FromFile((string)pic.Tag);
                }
                else
                {
                    ImageTemplate img = pic.Tag as ImageTemplate;
                    pic.Image = img.BackgroundImage;
                }
            }
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic.Image != null)
            {
                Cursor = Cursors.WaitCursor;
                pic.Image = Filter.Invert(pic.Image);
                Cursor = Cursors.Default;
                foreach (ImageTemplate img in pnl.Controls)
                {
                    if (pic.Tag.GetType() == typeof(ImageTemplate) && (ImageTemplate)pic.Tag == img)
                    {
                        img.Reload();
                    }
                }
            }
        }

        private void sepiaToneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic.Image != null)
            {
                Cursor = Cursors.WaitCursor;
                pic.Image = Filter.SepiaTone(pic.Image);
                Cursor = Cursors.Default;
                foreach (ImageTemplate img in pnl.Controls)
                {
                    if (pic.Tag.GetType() == typeof(ImageTemplate) && (ImageTemplate)pic.Tag == img)
                    {
                        img.Reload();
                    }
                }
            }
        }

        private void brighterImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic.Image != null)
            {
                {
                    Brighter br = new Brighter();
                    if (br.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        pic.Image = Filter.BrighterImage(pic.Image,br.trackBar1.Value);
                        Cursor = Cursors.Default;
                        foreach (ImageTemplate img in pnl.Controls)
                        {
                            if (pic.Tag.GetType() == typeof(ImageTemplate) && (ImageTemplate)pic.Tag == img)
                            {
                                img.Reload();
                            }
                        }
                    }
                }
            }
        }

        private void darkerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic.Image != null)
            {
                {
                    Darker dr = new Darker();
                    if (dr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        pic.Image = Filter.DarkerImage(pic.Image, dr.trackBar1.Value);
                        Cursor = Cursors.Default;
                        foreach (ImageTemplate img in pnl.Controls)
                        {
                            if (pic.Tag.GetType() == typeof(ImageTemplate) && (ImageTemplate)pic.Tag == img)
                            {
                                img.Reload();
                            }
                        }
                    }
                }
            }
        }

        private void detectEdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic.Image != null)
            {
                {
                    DetectEdges de = new DetectEdges();
                    if (de.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        pic.Image = Filter.DetectEdges(pic.Image, de.trackBar1.Value);
                        Cursor = Cursors.Default;
                        foreach (ImageTemplate img in pnl.Controls)
                        {
                            if (pic.Tag.GetType() == typeof(ImageTemplate) && (ImageTemplate)pic.Tag == img)
                            {
                                img.Reload();
                            }
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pic.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Bitmap bmp = (Bitmap)pic.Image;
                    bmp.Save(sfd.FileName + ".bmp");
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (pic.Image != null)
                FixSize();
        }

      
       

        

     

      
    }
}
