using System;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class DetectEdges : Form
    {
        public DetectEdges()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblStat.Text = "Detect edges when equation condition > " + trackBar1.Value;
        }
    }
}
