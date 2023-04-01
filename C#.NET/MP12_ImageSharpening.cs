using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP12_ImageSharpening
{
    public partial class MP12_ImageSharpening : Form
    {
        public MP12_ImageSharpening()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap hinhGoc = new Bitmap(@"E:\Nam_3\ThiGiacMay\Images\Lenna.jpg");
            picBoxHinhGoc.Image = hinhGoc;
            picBoxSharpening.Image = ColorImageSharpening(hinhGoc);
        }

        public Bitmap ColorImageSharpening(Bitmap hinhGoc)
        {
            Bitmap SharpenedImage = new Bitmap(hinhGoc.Width, hinhGoc.Height);
            byte[,] f = new byte[3, 5];
            for (int x = 1; x < hinhGoc.Width - 1; x++)
                for (int y = 1; y < hinhGoc.Height - 1; y++)
                {
                    //Tao 5 bien gan gia tri cua diem anh hien tai va cua 4 diem xung quanh
                    Color X0 = hinhGoc.GetPixel(x, y);
                    Color X1 = hinhGoc.GetPixel(x - 1, y);
                    Color X2 = hinhGoc.GetPixel(x + 1, y);
                    Color Y1 = hinhGoc.GetPixel(x, y - 1);
                    Color Y2 = hinhGoc.GetPixel(x, y + 1);

                    //Gan cac gia tri vao cac mang R,G,B rieng biet
                    f[0, 0] = X0.R;
                    f[0, 1] = X1.R;
                    f[0, 2] = X2.R;
                    f[0, 3] = Y1.R;
                    f[0, 4] = Y2.R;

                    f[1, 0] = X0.G;
                    f[1, 1] = X1.G;
                    f[1, 2] = X2.G;
                    f[1, 3] = Y1.G;
                    f[1, 4] = Y2.G;

                    f[2, 0] = X0.B;
                    f[2, 1] = X1.B;
                    f[2, 2] = X2.B;
                    f[2, 3] = Y1.B;
                    f[2, 4] = Y2.B;

                    int[] g = new int[3];
                    for (int k = 0; k < 3; k++)
                    {
                        //g(x,y) = f(x,y) + c*v^2(x,y), chọn c = -1
                        //v^2(x,y) = f(x - 1, y) + f(x + 1, y) + f(x, y - 1) + f(x,y + 1) - 4*f(x,y)
                        g[k] = f[k, 0] + 4 * f[k, 0] - f[k, 1] - f[k, 2] - f[k, 3] - f[k, 4];
                        if (g[k] < 0)  g[k] = 0; 
                        if (g[k] > 255)  g[k] = 255; 
                    }
                    SharpenedImage.SetPixel(x, y, Color.FromArgb(g[0], g[1], g[2]));
                }
            return SharpenedImage;
        }
    }
}
