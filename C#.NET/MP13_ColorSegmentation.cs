using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP13_ColorSegmentation
{
    public partial class MP13_ColorSegmentation : Form
    {
        Bitmap hinhGoc;
        int x1, x2, y1, y2, nguong;
        public MP13_ColorSegmentation()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x1 = Int32.Parse(textBox_x1.Text);
            x2 = Int32.Parse(textBox_x2.Text);
            y1 = Int32.Parse(textBox_y1.Text);
            y2 = Int32.Parse(textBox_y2.Text);
            nguong = (byte)trackBar1.Value;
            picBox_segmentation.Image = ColorSegmentation(hinhGoc, x1, x2, y1, y2, nguong);
        }

        private void MP13_ColorSegmentation_Load(object sender, EventArgs e)
        {
            hinhGoc = new Bitmap(@"E:\Nam_3\ThiGiacMay\Images\Lenna.jpg");
            picBoxHinhGoc.Image = hinhGoc;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_trackBar.Text = trackBar1.Value.ToString();

        }
        public Bitmap ColorSegmentation(Bitmap hinhGoc, int x1, int x2, int y1, int y2, int nguong)
        {
            Bitmap ImageSegmentation = new Bitmap(hinhGoc.Width, hinhGoc.Height);
            // averageRGB là vecto màu trung bình
            double[] averageRGB = new double[3];
            // So diem anh trong vung da chon:
            int SoDiemAnh = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            for (int x = x1; x <= x2; x++)
                for (int y = y1; y <= y2; y++)
                {
                    Color RGB_Image = hinhGoc.GetPixel(x, y);
                    averageRGB[0] += RGB_Image.R;
                    averageRGB[1] += RGB_Image.G;
                    averageRGB[2] += RGB_Image.B;
                }
            averageRGB[0] = (int)(averageRGB[0] / SoDiemAnh);
            averageRGB[1] = (int)(averageRGB[1] / SoDiemAnh);
            averageRGB[2] = (int)(averageRGB[2] / SoDiemAnh);

            for (int x = 0; x < hinhGoc.Width; x++)
                for (int y = 0; y < hinhGoc.Height; y++)
                {
                    Color RGB_Image = hinhGoc.GetPixel(x, y);
                    double zR = RGB_Image.R;
                    double zG = RGB_Image.G;
                    double zB = RGB_Image.B;
                    int D_za = (int)Math.Sqrt((zR - averageRGB[0]) * (zR - averageRGB[0]) +
                        (zG - averageRGB[1]) * (zG - averageRGB[1]) + (zB - averageRGB[2]) *
                        (zB - averageRGB[2]));
                    if (D_za <= nguong)
                    {
                        zR = 255;
                        zG = 255;
                        zB = 255;
                    }
                    ImageSegmentation.SetPixel(x, y, Color.FromArgb((byte)zR, (byte)zG, (byte)zB));
                }
            return ImageSegmentation;
        }

        private void textBox_x1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
