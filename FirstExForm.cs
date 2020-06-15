using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class FirstExForm : Form
    {
        public FirstExForm()
        {
            InitializeComponent();
        }

        private void draw_Click(object sender, EventArgs e)
        {
           
            Pen bluePen = new Pen(Color.Blue, 3);
            Graphics gEllips = Graphics.FromHwnd(pictureBox1.Handle);
            int x = 0;
            int y = 0;
            int width = 200;
            int height = 100;
            gEllips.DrawEllipse(bluePen, x, y, width, height);

            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Graphics gEllips1 = Graphics.FromHwnd(pictureBox1.Handle);
            int x1 = 0;
            int y1 = 0;
            int width1 = 200;
            int height1 = 100;
            int startAngle = 0;
            int sweepAngle = 45;
            gEllips.FillPie(blueBrush, x1, y1, width1, height1, startAngle, sweepAngle);


            Pen blackPen = new Pen(Color.Black, 3);
            Graphics gPolygon = Graphics.FromHwnd(pictureBox2.Handle);
            Point point1 = new Point(80, 10);
            Point point2 = new Point(30, 60);
            Point point3 = new Point(53, 110);
            Point point4 = new Point(107, 110);
            Point point5 = new Point(130, 60);
            Point[] curvePoints = { point1, point2, point3, point4, point5 };
            gPolygon.DrawPolygon(blackPen, curvePoints);


            Pen redPen = new Pen(Color.Red, 2);
            Graphics gRhomb = Graphics.FromHwnd(pictureBox3.Handle);
            Point point11 = new Point(0, 250 / 2);
            Point point21 = new Point(250 / 2, 0);
            Point point31 = new Point(250, 250 / 2);
            Point point41 = new Point(250 / 2, 250);
            Point[] curvePoints2 = { point11, point21, point31, point41 };
            gRhomb.DrawPolygon(redPen, curvePoints2);



            Pen purPen = new Pen(Color.Purple, 2);
            Graphics gCube = Graphics.FromHwnd(pictureBox4.Handle);
            Point pnt1 = new Point(200, 5);
            Point pnt2 = new Point(100, 5);
            Point pnt3 = new Point(200, 105);
            Point pnt4 = new Point(100, 105);
            Point pnt5 = new Point(250, 55);
            Point pnt6 = new Point(150, 55);
            Point pnt7 = new Point(250, 155);
            Point pnt8 = new Point(150, 155);

            gCube.DrawLine(purPen, pnt1, pnt2);
            gCube.DrawLine(purPen, pnt1, pnt3);
            gCube.DrawLine(purPen, pnt2, pnt4);
            gCube.DrawLine(purPen, pnt3, pnt4);
            gCube.DrawLine(purPen, pnt5, pnt6);
            gCube.DrawLine(purPen, pnt5, pnt7);
            gCube.DrawLine(purPen, pnt6, pnt8);
            gCube.DrawLine(purPen, pnt7, pnt8);
            gCube.DrawLine(purPen, pnt1, pnt5);
            gCube.DrawLine(purPen, pnt2, pnt6);
            gCube.DrawLine(purPen, pnt3, pnt7);
            gCube.DrawLine(purPen, pnt4, pnt8);

        }
    }
}
