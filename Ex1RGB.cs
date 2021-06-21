using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public partial class Ex1RGB : Form
    {

        
        RGB RGB;
        Color color=new Color();
        public Ex1RGB(RGB rgb)
        {
            MinimumSize=new Size(800, 600);
            MaximumSize=new Size(800, 600);
            InitializeComponent();
            trackBar1.Maximum = 255;
            trackBar1.Minimum = 0;
            trackBar2.Maximum = 255;
            trackBar2.Minimum = 0;
            trackBar3.Maximum = 255;
            trackBar3.Minimum = 0;
            trackBar1.Value = rgb.R;
            trackBar2.Value = rgb.G;
            trackBar3.Value = rgb.B;
            RGB = rgb;
            color =Color.FromArgb(rgb.R, rgb.G, rgb.B);
            this.BackColor = color;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }
      

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RGB.R = trackBar1.Value;
            RGB.G = trackBar2.Value;
            RGB.B = trackBar3.Value;
            Close();
        }
    }
}
