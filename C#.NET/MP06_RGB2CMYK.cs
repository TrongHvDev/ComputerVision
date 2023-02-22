using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB2CMYK
{
    public partial class MP06_RGB2CMYK : Form
    {
        public MP06_RGB2CMYK()
        {
            InitializeComponent();
            Bitmap HinhGoc = new Bitmap(@"E:\Nam_3\ThiGiacMay\Images\Lenna.jpg");
            picBoxHInhGoc.Image = HinhGoc;

            List<Bitmap> CMYK = RGB2CMYK(HinhGoc);
            picBox_cyan.Image = CMYK[0];
            picBox_Magenta.Image = CMYK[1];
            picBox_Yellow.Image = CMYK[2];
            picBox_Black.Image = CMYK[3];
        }

        public List<Bitmap> RGB2CMYK(Bitmap HinhGoc)
        {
            List<Bitmap> CMYK = new List<Bitmap>();
            Bitmap Cyan = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap Magenta = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap Yellow = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap Black = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++) {
                    Color pixel = HinhGoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    Cyan.SetPixel(x, y, Color.FromArgb(0, G, B));
                    Magenta.SetPixel(x, y, Color.FromArgb(R, 0, B));
                    Yellow.SetPixel(x, y, Color.FromArgb(R, G, 0));
                    byte K = Math.Min(R, Math.Min(G, B));
                    Black.SetPixel(x, y, Color.FromArgb(K, K, K));
                }
            CMYK.Add(Cyan);
            CMYK.Add(Magenta);
            CMYK.Add(Yellow);
            CMYK.Add(Black);
            return CMYK;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
