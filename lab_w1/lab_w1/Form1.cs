using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_w1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap srcBitmap = new Bitmap(pictureBox1.Image);
            for (int i=1;i<120;i++)
            {
                srcBitmap.SetPixel(i, 10+i, Color.Red);
            }
            pictureBox1.Image = srcBitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Color clr = bmp.GetPixel(e.X, e.Y);
            label1.Text = "R: " + clr.R.ToString();
            label2.Text = "G: " + clr.G.ToString();
            label3.Text = "B: " + clr.B.ToString();
        }

        public Bitmap ConvertToGray(Bitmap src)
        {
            Bitmap bmp = new Bitmap(src.Width, src.Height);
            int avg;
            for (int x = 0; x < bmp.Width;x++)
            {
                for (int y = 0; y<bmp.Height;y++)
                {
                    Color c = src.GetPixel(x, y);
                    avg = ((c.R + c.G + c.B) / 3);
                    bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }

            return bmp;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ConvertToGray(new Bitmap("image.jpg"));
        }
    }
}
