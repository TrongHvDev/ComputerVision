using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP07_RGB2HSI
{
    public partial class MP08_RGB2HSV : Form
    {
        public MP08_RGB2HSV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap HinhGoc = new Bitmap(@"E:\Nam_3\ThiGiacMay\Images\Lenna.jpg");
            picBoxHinhGoc.Image = HinhGoc;

            List<Bitmap> HSI = RGB2HSI(HinhGoc);
            picBoxHUE.Image =       HSI[0];
            picBoxSaturaion.Image = HSI[1];
            picBoxValue.Image = HSI[2];
            picBoxHSI.Image =       HSI[3];

        }
        public List <Bitmap> RGB2HSI(Bitmap HinhGoc)
        {
            List<Bitmap> HSI = new List<Bitmap>();    //tao mang dong List de chua cac hinh sau khi chuyen doi
            Bitmap Hue = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap Saturaion = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap Value = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap HSIimg = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    Color pixel = HinhGoc.GetPixel(x, y);
                    // dung kieu du lieu double vi trong qua trinh tinh toan HSI thi tra ve so thuc
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    double t1 = ((R - G) + (R - B)) / 2;
                    double t2 = Math.Sqrt((R - G) * (R - G) + (R - B) * (G - B));
                    double theta = Math.Acos(t1 / t2);

                    //Tinh gia tri H
                    double H = 0;
                    if (B <= G)
                        H = theta;
                    else
                        H = 2 * Math.PI - theta; //Gia tri goc hien tai dang la Radian

                    H = H * 180 / Math.PI; //Chuyen ve gia tri Do

                    //Tinh gia tri S
                    double S = 1 - 3 * Math.Min(R, Math.Min(G, B)) / (R + G + B);

                    //Tinh gia tri I
                    double V = Math.Max(R , Math.Max(G , B));

                    //hien thi hinh
                    Hue.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    Value.SetPixel(x, y, Color.FromArgb((byte)V, (byte)V, (byte)V));
                    Saturaion.SetPixel(x, y, Color.FromArgb((byte)(S*255), (byte)(S * 255), (byte)(S * 255)));
                    HSIimg.SetPixel(x, y, Color.FromArgb((byte)H, (byte)(S*255), (byte)V));

                    HSI.Add(Hue);
                    HSI.Add(Saturaion);
                    HSI.Add(Value);
                    HSI.Add(HSIimg);

                    
                }
            return HSI;
        }
    }
}
