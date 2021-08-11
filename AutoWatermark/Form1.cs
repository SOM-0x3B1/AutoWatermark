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
            string[] srcimages = Directory.GetFiles(@".\sourceImages\");
            string[] watermarks = Directory.GetFiles(@".\sourceImages\watermarks");

            if (watermarks.Length > 0)
            {
                Bitmap srcImage = null;
                Bitmap thumbnail = null;
                Bitmap watermark = null;

                for (int i = 0; i < srcimages.Length; i++)
                {
                    if (srcImage != null)
                        srcImage.Dispose();
                    srcImage = new Bitmap(srcimages[i]);

                    if (thumbnail != null)
                        thumbnail.Dispose();
                    thumbnail = new Bitmap(srcImage, new Size(356, 200));
                    thumbnail.Save((@".\resultImages\thumbnails\" + i.ToString() + ".png"), ImageFormat.Png);


                    RefreshDisplay(i, srcimages.Length, thumbnail);
                }


                for (int i = 0; i < srcimages.Length; i++)
                {
                    if (srcImage != null)
                        srcImage.Dispose();
                    srcImage = new Bitmap(srcimages[i]);

                    if (watermark != null)
                        watermark.Dispose();
                    watermark = new Bitmap(watermarks[i % watermarks.Length - 1]);

                    using (Graphics g = Graphics.FromImage(srcImage)) { g.DrawImage(watermark, new Point(0, 0)); }
                    srcImage.Save((@".\resultImages\watermarked\" + i.ToString() + ".png"), ImageFormat.Png);

                    RefreshDisplay(i, srcimages.Length, srcImage);
                }
            }
            else
                MessageBox.Show(@"Please add at least one watermark image to '.\sourceImages\watermarks'", "Watermark not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshDisplay(int i, int length, Bitmap img)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = new Bitmap(img, pictureBox1.Size);
            pictureBox1.Refresh();

            label4.Text = i + 1 + "/" + length;
            label4.Refresh();
        }
    }
}
