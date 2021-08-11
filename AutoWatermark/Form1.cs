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

            Bitmap srcImage;
            Bitmap thumbnail;
            Bitmap watermarked;

            for (int i = 0; i < images.Length; i++)
            {
                srcImage = new Bitmap(images[i]);

                thumbnail = new Bitmap(srcImage, new Size(356, 200));
                thumbnail.Save((@".\resultImages\thumbnails\" + i.ToString() + ".png"), ImageFormat.Png);

                thumbnailprogress.Value = i / (images.Length-1) * 100;

                Thread.Sleep(2000);
            }
        }
    }
}
