using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TachMauRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string fileHinh = @"E:\Nam_3\ThiGiacMay\Images\lenna.jpg";
            Bitmap hinhGoc = new Bitmap(fileHinh);
            picBox_AnhGoc.Image = hinhGoc;

            //hiển thị các kênh màu RGB

            Bitmap red = new Bitmap(hinhGoc.Width, hinhGoc.Height);
            Bitmap green = new Bitmap(hinhGoc.Width, hinhGoc.Height);
            Bitmap blue = new Bitmap(hinhGoc.Width, hinhGoc.Height);

            // Mỗi ảnh là một ma trận 2 chiều nên dùng 2 vòng for để quét hết các pixel trong ảnh

            for (int x = 0; x < hinhGoc.Width; x++)
                for (int y = 0; y < hinhGoc.Height; y++)
                {
                    //đọc pixel tại điểm ảnh
                    Color pixel = hinhGoc.GetPixel(x, y);

                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B; // gia tri kenh blue
                    byte A = pixel.A; //gia tri do trong suot

                    // set cac gia tri pixel doc duoc tuong ung voi tung hinh
                    //cac kenh mau RGB

                    red.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    blue.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));



                }
            //hien thi ra imgbox

            picBox_KenhRED.Image = red;
            picBox_KenhGreen.Image = green;
            picBox_KenhBlue.Image = blue;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
