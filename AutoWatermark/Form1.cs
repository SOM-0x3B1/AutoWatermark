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

namespace AutoWatermark
{
    public partial class Form1 : Form
    {
        private int totalprogress = 0;
        private string htmlProjectFolder = "sugarrushimages";

        public Form1()
        {
            InitializeComponent();
        }

        private void start(object sender, EventArgs e)
        {
            string[] srcimages = Directory.GetFiles(@".\sourceImages\");
            string[] watermarks = Directory.GetFiles(@".\sourceImages\watermarks");


            Bitmap srcImage = null;
            Bitmap thumbnail = null;
            Bitmap watermark = null;

            if (pthumb.Image != null)
                pthumb.Image.Dispose();
            pthumb.Image = new Bitmap(this.pthumb.Width, this.pthumb.Height);
            if (pwater.Image != null)
                pwater.Image.Dispose();
            pwater.Image = new Bitmap(this.pthumb.Width, this.pthumb.Height);
            if (ptotal.Image != null)
                ptotal.Image.Dispose();
            ptotal.Image = new Bitmap(this.pthumb.Width, this.pthumb.Height);

            totalprogress = 0;

            for (int i = 0; i < srcimages.Length; i++)
            {
                if (srcImage != null)
                    srcImage.Dispose();
                srcImage = new Bitmap(srcimages[i]);

                if (thumbnail != null)
                    thumbnail.Dispose();
                thumbnail = new Bitmap(srcImage, new Size(356, 200));
                thumbnail.Save((@".\resultImages\thumbnails\" + (i+1).ToString() + "t.png"), ImageFormat.Png);

                UpdateProgress(i, srcimages.Length, pthumb.Image);
                UpdateLabelProgress(i, srcimages.Length, thumbnail);

                richTextBox1.Text += "<div class='image'>\n\t<img src = 'media/" + htmlProjectFolder + "/" + (i + 1) + "t.png' onclick = 'modal(this.src)'>\n</div>\n";
                richTextBox1.Refresh();

                totalprogress++;
            }


            for (int i = 0; i < srcimages.Length; i++)
            {
                if (srcImage != null)
                    srcImage.Dispose();
                srcImage = new Bitmap(srcimages[i]);

                if (watermarks.Length > 0)
                {
                    if (watermark != null)
                        watermark.Dispose();
                    watermark = new Bitmap(watermarks[i % watermarks.Length]);

                    using (Graphics g = Graphics.FromImage(srcImage))
                    {
                        g.DrawImage(watermark, new Point(0, 0));
                    }                   
                }
                srcImage.Save((@".\resultImages\watermarked\" + (i+1).ToString() + ".png"), ImageFormat.Png);

                UpdateProgress(i, srcimages.Length, pwater.Image);
                UpdateLabelProgress(i, srcimages.Length, srcImage);

                totalprogress += 2;
            }

            /* else
                 MessageBox.Show(@"Please add at least one watermark image to '.\sourceImages\watermarks'", "Watermark not found", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void UpdateLabelProgress(int i, int length, Bitmap img)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = new Bitmap(img, pictureBox1.Size);
            pictureBox1.Refresh();

            label4.Text = i + 1 + "/" + length;
            label4.Refresh();
        }

        private void UpdateProgress(int i, int length, Image img)
        {
            using (Graphics g = Graphics.FromImage(img))
            {
                g.FillRectangle(Brushes.Blue, new Rectangle(new Point(0, 0), new Size(Convert.ToInt32(ptotal.Width * ((double)i / length)), 18)));
            }
            using (Graphics g = Graphics.FromImage(ptotal.Image))
            {
                g.FillRectangle(Brushes.Blue, new Rectangle(new Point(0, 0), new Size(Convert.ToInt32(ptotal.Width * ((double)totalprogress / (length * 3))), 18)));
            }
            pthumb.Refresh();
            pwater.Refresh();
            ptotal.Refresh();
        }
    }
}