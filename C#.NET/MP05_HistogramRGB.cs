using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
namespace MP05_HistogramRGB
{
    public partial class MP05_HistogramRGB : Form
    {
        public MP05_HistogramRGB()
        {
            InitializeComponent();
            Bitmap HinhGoc = new Bitmap(@"E:\Nam_3\ThiGiacMay\Images\bird_small.jpg");
            pictureBox1.Image = HinhGoc;
            double[,] his = HistogramCalc(HinhGoc);
            List<PointPairList> points = ChuyendoiHistogram(his);

            zedGraph.GraphPane = BieudoHistogram(points);
            zedGraph.Refresh();
        }

        public double[,] HistogramCalc(Bitmap AnhRGB) {
            double[,] his = new double[3, 256];

            for (int x = 0; x < AnhRGB.Width; x++) {
                for (int y = 0; y < AnhRGB.Height; y++)
                {
                    Color pixel = AnhRGB.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    his[0, R]++;
                    his[1, G]++;
                    his[2, B]++;
                }
            }
            return his;
        }

        List<PointPairList> ChuyendoiHistogram(double[,] histogram)
        {
            //PointPairList la kieu du lieu cua Zedgraph de ve bieu do
            List<PointPairList> points = new List<PointPairList>();
            PointPairList redPoints = new PointPairList();  //Chua histogram kenh R
            PointPairList greenPoints = new PointPairList();//Chua histogram kenh G
            PointPairList bluePoints = new PointPairList(); //Chua histogram kenh B
            for (int i = 0; i < 256; i++)
            {
                //i tuong ung truc nam ngang tu 0 - 255
                //Histogram tuong ung truc dung, la so pixel
                greenPoints.Add(i, histogram[1, i]);    //Chuyen doi cho kenh G
                redPoints.Add(i, histogram[0, i]);      //Chuyen doi cho kenh R                   
                bluePoints.Add(i, histogram[2, i]);     //Chuyen doi cho kenh B

            }
            points.Add(redPoints);
            points.Add(greenPoints);
            points.Add(bluePoints);

            return points;

        }

        //Thiet lap mot bieu do trong Zedgraph
        public GraphPane BieudoHistogram(List<PointPairList> histogram)
        {
            //GraphPane la doi tuong trong Zedgraph
            GraphPane gp = new GraphPane();

            gp.Title.Text = @"Biểu đồ Histogram";
            gp.Rect = new Rectangle(0, 0, 700, 500);//Khung chua bieu do

            //Thiet lap truc ngang
            gp.XAxis.Title.Text = @"Giá trị mau của các điểm ảnh";
            gp.XAxis.Scale.Min = 0; // nho nhat la 0
            gp.XAxis.Scale.Max = 255; // lon nhat la 255
            gp.XAxis.Scale.MajorStep = 5;// Moi buoc chinh la 5
            gp.XAxis.Scale.MinorStep = 1; //Moi buoc trong mot buoc chinh la 1

            //Tuong tu thiet lap cho truc dung
            gp.YAxis.Title.Text = @"Số điểm ảnh có cùng giá trị màu";
            gp.YAxis.Scale.Min = 0; // nho nhat la 0
            gp.YAxis.Scale.Max = 15000; // So nay phai lon hon kich thuoc anh
            gp.YAxis.Scale.MajorStep = 5;// Moi buoc chinh la 5
            gp.YAxis.Scale.MinorStep = 1; //Moi buoc trong mot buoc chinh la 1

            //Dung bieu do dang bar de bieu dien histgram          
            gp.AddBar("Histogram's Red", histogram[0], Color.Red);
            gp.AddBar("Histogram's Green", histogram[1], Color.Green);
            gp.AddBar("Histogram's Blue", histogram[2], Color.Blue);

            return gp;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
