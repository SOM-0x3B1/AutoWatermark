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
using System.Drawing;

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
            string[] images = Directory.GetFiles(@".\srcImages\");
            Bitmap img;

            for (int i = 0; i < images.Length; i++)
            {
                img = new Bitmap(images[i]);

                using (Graphics g = Graphics.FromImage(img))
                {

                }                
            }
        }
    }
}
