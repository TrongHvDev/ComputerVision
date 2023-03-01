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
    public partial class MP09_RGB2XYZ : Form
    {
        public MP09_RGB2XYZ()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap HinhGoc = new Bitmap(@"E:\Nam_3\ThiGiacMay\Images\Lenna.jpg");
            picBoxHinhGoc.Image = HinhGoc;

            List<Bitmap> XYZ = RGB2XYZ(HinhGoc);
            picBoxX.Image =       XYZ[0];
            picBoxY.Image = XYZ[1];
            picBoxZ.Image = XYZ[2];
            picBoxXYZ.Image =       XYZ[3];

        }
        public List <Bitmap> RGB2XYZ(Bitmap HinhGoc)
        {
            List<Bitmap> HSI = new List<Bitmap>();    //tao mang dong List de chua cac hinh sau khi chuyen doi
            Bitmap X_img = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap Y_img = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap Z_img = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap XYZimg = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    Color pixel = HinhGoc.GetPixel(x, y);
                    // dung kieu du lieu double vi trong qua trinh tinh toan HSI thi tra ve so thuc
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    double X = (0.4124564 * R + 0.3575761 * G + 0.1804375 * B);
                    double Y = (0.2126729 * R + 0.7151522 * G + 0.0721750 * B);
                    double Z = (0.0193339 * R + 0.1191920 * G + 0.9503041 * B);

                    //hien thi hinh
                    X_img.SetPixel(x, y, Color.FromArgb((byte)X, (byte)X, (byte)X));
                    Y_img.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    Z_img.SetPixel(x, y, Color.FromArgb((byte)Z, (byte)Z, (byte)Z));
                    XYZimg.SetPixel(x, y, Color.FromArgb((byte)X, (byte)Y, (byte)Z));

                    HSI.Add(X_img);
                    HSI.Add(Y_img);
                    HSI.Add(Z_img);
                    HSI.Add(XYZimg);

                    
                }
            return HSI;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
