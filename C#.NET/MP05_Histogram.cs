using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using ZedGraph;

namespace MP05_Histogram
{
    public partial class MP05_Histogram : Form
    {
        public MP05_Histogram()
        {
            InitializeComponent();
            Bitmap HinhGoc = new Bitmap(@"E:\Nam_3\ThiGiacMay\Images\bird_small.jpg");
            picBox.Image = HinhGoc;

            Bitmap GrayImg = RGBtoGRAY_Average(HinhGoc);
            double[] his = HistogramCalc(GrayImg);
            PointPairList points = HistogramConvert(his);

            //Ve bieu do histogram va cho hien thi
            zedGraphHistogram.GraphPane = HistogramGraph(points);
            zedGraphHistogram.Refresh();
        }



        public Bitmap RGBtoGRAY_Average(Bitmap HinhGoc)
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

                    byte gray = (byte)((R + G + B) / 3);
                    GrayImg.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return GrayImg;
        }
        //--------------------------------------------------------------------------------------------------
        //-----------------------------Tinh Histogram-------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public double[] HistogramCalc(Bitmap GrayImg) {
            double[] his = new double[256];

            for (int x = 0; x < GrayImg.Width; x++)
            {
                for (int y = 0; y < GrayImg.Height; y++) {
                    Color color = GrayImg.GetPixel(x, y);
                    byte gray = color.R;
                    //Lay red trong hinh xam vi trong hinh xam red = green = blue
                    his[gray]++;
                }

            }
            return his;

        }
        //----------------------------------------------------------------------------------------------------
        // chuyen du lieu tu dang ma tran sang kieu du lieu cua zedgraph
        PointPairList HistogramConvert(double[] his) {
            PointPairList points = new PointPairList();

            for (int i = 0; i < his.Length; i++)
            {
                points.Add(i, his[i]);

            }
            return points;
        }
        //thiet lap mot bieu do trong zedgraph
        public GraphPane HistogramGraph(PointPairList his)
        {
            GraphPane gp = new GraphPane();
            gp.Title.Text = @"Biểu đồ Histogram";
            gp.Rect = new Rectangle(0, 0, 700, 500); //Khung chua bieu do

            //Thiet lap truc ngang
            gp.XAxis.Title.Text = @"Giá trị mức xám của các điểm ảnh";
            gp.XAxis.Scale.Min = 0; // nho nhat la 0
            gp.XAxis.Scale.Max = 255; // lon nhat la 255
            gp.XAxis.Scale.MajorStep = 5;// Moi buoc chinh la 5
            gp.XAxis.Scale.MinorStep = 1; //Moi buoc trong mot buoc chinh la 1

            //Tuong tu thiet lap cho truc dung
            gp.YAxis.Title.Text = @"Số điểm ảnh có cùng mức xám";
            gp.YAxis.Scale.Min = 0; // nho nhat la 0
            gp.YAxis.Scale.Max = 15000; // So nay phai lon hon kich thuoc anh
            gp.YAxis.Scale.MajorStep = 5;// Moi buoc chinh la 5
            gp.YAxis.Scale.MinorStep = 1; //Moi buoc trong mot buoc chinh la 1

            gp.AddBar("Histogram", his, Color.OrangeRed);
            return gp;

        }

        private void MP05_Histogram_Load(object sender, EventArgs e)
        {

        }
    }
}

