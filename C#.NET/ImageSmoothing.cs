using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoothImage
{
    public partial class ImageSmoothing : Form
    {
        public ImageSmoothing()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap hinhGoc = new Bitmap(@"E:\Nam_3\ThiGiacMay\Images\Lenna.jpg");
            // Load anh vao picbox
            picBoxHinhGoc.Image = hinhGoc;
            picBox_3x3.Image = ColorImageSmoothing(hinhGoc, 3);
            picBox_5x5.Image = ColorImageSmoothing(hinhGoc, 5);
            picBox_7x7.Image = ColorImageSmoothing(hinhGoc, 7);
            picBox_9x9.Image = ColorImageSmoothing(hinhGoc, 9);

        }
        public Bitmap ColorImageSmoothing(Bitmap hinhGoc, int mask)
        {
            Bitmap SmoothedImage = new Bitmap(hinhGoc.Width, hinhGoc.Height);
            // Quet cac diem anh trong hinh goc RGB
            // Do mat na 3x3 nen bo qua vien ngoai cua anh
            int offset = 0;
            if (mask == 3) offset = 1; 
            if (mask == 5) offset = 2; 
            if (mask == 7) offset = 3; 
            if (mask == 9) offset = 4;

            for (int x = offset; x < hinhGoc.Width - offset; x++)
                for(int y = offset; y < hinhGoc.Height - offset; y++)
                {
                    //Cac bien de chua gia tri cong don cac diem anh
                    int Rs = 0, Gs = 0, Bs = 0;

                    //Quet cac diem anh trong mat na
                    for (int i = x - offset; i <= x + offset; i++)
                        for (int j = y - offset; j <= y + offset; j++)
                        {
                            //Lay thong tin mau RGB tai diem anh trong mat na
                            //tai vi tri (i;j)
                            Color color = hinhGoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Cong don tat ca cac diem ah do cho moi kenh
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    //Ket thuc quet va cong don diem anh trong mat na
                    //Bat dau tinh trung binh cong cho moi kenh theo cong thuc 6.6-1 trong sach
                    //cho tung kenh mau R,G,B
                    int K = mask * mask;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    SmoothedImage.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return SmoothedImage;
        }

    }
}
