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
    public partial class MP10_RGB2YCrCb : Form
    {
        public MP10_RGB2YCrCb()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap HinhGoc = new Bitmap(@"E:\Nam_3\ThiGiacMay\Images\Lenna.jpg");
            picBoxHinhGoc.Image = HinhGoc;

            List<Bitmap> YCrCb = RGB2YCrCb(HinhGoc);
            picBoxY.Image =       YCrCb[0];
            picBoxCr.Image = YCrCb[1];
            picBoxCb.Image = YCrCb[2];
            picBoxYCrCb.Image =       YCrCb[3];

        }
        public List <Bitmap> RGB2YCrCb(Bitmap HinhGoc)
        {
            List<Bitmap> YCrCb = new List<Bitmap>();    //tao mang dong List de chua cac hinh sau khi chuyen doi
            Bitmap Y_img = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap Cr_img = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap Cb_img = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap YCrCbimg = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    Color pixel = HinhGoc.GetPixel(x, y);
                    // dung kieu du lieu double vi trong qua trinh tinh toan HSI thi tra ve so thuc
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    double Y = (16 + (65.738 / 256) * R + (129.057 / 256) * G + (25.064 / 256) * B);
                    double Cr = (128 - (37.945 / 256) * R - (74.494 / 256) * G + (112.439 / 256) * B);
                    double Cb = (128 + (112.439 / 256) * R - (94.154 / 256) * G - (18.285 / 256) * B);

                    //hien thi hinh
                    Y_img.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    Cr_img.SetPixel(x, y, Color.FromArgb((byte)Cr, (byte)Cr, (byte)Cr));
                    Cb_img.SetPixel(x, y, Color.FromArgb((byte)Cb, (byte)Cb, (byte)Cb));
                    YCrCbimg.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Cr, (byte)Cb));

                    YCrCb.Add(Y_img);
                    YCrCb.Add(Cr_img);
                    YCrCb.Add(Cb_img);
                    YCrCb.Add(YCrCbimg);

                    
                }
            return YCrCb;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
