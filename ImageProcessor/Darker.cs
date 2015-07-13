using System;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class Darker : Form
    {
        public Darker()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblStat.Text = "Decrease Brightness by " + trackBar1.Value + " bytes";
        }
    }
}
