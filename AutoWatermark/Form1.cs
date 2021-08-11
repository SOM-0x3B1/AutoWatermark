using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace AutoWatermark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void start(object sender, EventArgs e)
        {
            string[] images = Directory.GetFiles(@".\sourceImages\");

            Bitmap srcImage = null;
            Bitmap thumbnail = null;
            Bitmap watermarked = null;

            for (int i = 0; i < images.Length; i++)
            {      
                if(srcImage != null)
                    srcImage.Dispose();
                srcImage = new Bitmap(images[i]);

                if (thumbnail != null)
                    thumbnail.Dispose();
                thumbnail = new Bitmap(srcImage, new Size(356, 200));
                thumbnail.Save((@".\resultImages\thumbnails\" + i.ToString() + ".png"), ImageFormat.Png);

                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();
                pictureBox1.Image = new Bitmap(thumbnail, pictureBox1.Size);
                pictureBox1.Refresh();

                label4.Text = i + 1 + "/" + images.Length;
                label4.Refresh();
            }
        }
    }
}
