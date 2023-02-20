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
using Emgu.CV.Util;

namespace XLA_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Image<Bgr, byte> hinhHienThi = new Image<Bgr, byte>(@"E:\Nam_3\ThiGiacMay\Images\lenna.jpg"); // @ de bien chuoi duong dan thanh chuoi unicode
            imgbox.Image = hinhHienThi;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
