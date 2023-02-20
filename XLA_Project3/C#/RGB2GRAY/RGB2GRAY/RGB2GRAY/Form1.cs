using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB2GRAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap HinhGoc = new Bitmap(@"E:\Nam_3\ThiGiacMay\Images\bird_small.jpg");
            picBox_HinhGoc.Image = HinhGoc;
            picBox_Avg.Image = RGBtoGRAY_Average(HinhGoc);
            picBox_Light.Image = RGBtoGRAY_Lightness(HinhGoc);
            picBox_Luminance.Image = RGBtoGRAY_Luminance(HinhGoc);
        }

        public Bitmap RGBtoGRAY_Average (Bitmap HinhGoc) {
            Bitmap GrayImg = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 0; x < HinhGoc.Width; x++) {
                for (int y = 0; y < HinhGoc.Height; y++) {
                    Color pixel = HinhGoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte gray = (byte)((R + G + B) / 3);
                    GrayImg.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return GrayImg;
        }

        public Bitmap RGBtoGRAY_Lightness(Bitmap HinhGoc)
        {
            Bitmap GrayImg = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 0; x < HinhGoc.Width; x++)
            {
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    Color pixel = HinhGoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));
                    byte gray = (byte)((max + min) / 2);
                    GrayImg.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return GrayImg;
        }
        public Bitmap RGBtoGRAY_Luminance(Bitmap HinhGoc)
        {
            Bitmap GrayImg = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 0; x < HinhGoc.Width; x++)
            {
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    Color pixel = HinhGoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte gray = (byte)(0.2126*R + 0.7152*G + 0.0722*B);
                    GrayImg.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return GrayImg;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
