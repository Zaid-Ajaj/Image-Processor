using System;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class Brighter : Form
    {
        public Brighter()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblStat.Text = "Increase Brightness by " + trackBar1.Value + " bytes";
        }
    }
}
