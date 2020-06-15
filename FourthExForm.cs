using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class FourthExForm : Form
    {
        public FourthExForm()
        {
            InitializeComponent();


        }

        public Graphics Corp { get; set; }
        public Graphics Roof { get; set; }
        public Graphics RoofDecor { get; set; }

        public Graphics BackWheel { get; set; }
        public Graphics FrontWheel { get; set; }
        public Graphics Lamp { get; set; }

    private void button1_Click(object sender, EventArgs e)
        {
            Corp = DrawCorp(Graphics.FromHwnd(pictureBox1.Handle));
            Roof = DrawRoof(Graphics.FromHwnd(pictureBox1.Handle));
            BackWheel = DrawWheel(Graphics.FromHwnd(pictureBox1.Handle));
            FrontWheel = DrawWheel(Graphics.FromHwnd(pictureBox1.Handle), 240);
            Lamp = DrawLamp(Graphics.FromHwnd(pictureBox1.Handle));
            RoofDecor = DrawRoofDecor(Graphics.FromHwnd(pictureBox1.Handle));
            
            for (var i = 0; i < 400; i++)
            {
                Thread.Sleep(12);
                Corp.Clear(BackColor);
                Roof.Clear(BackColor);
                BackWheel.Clear(BackColor);
                FrontWheel.Clear(BackColor);

                Corp = DrawCorp(Corp, 0 + i);
                Roof = DrawRoof(Roof, 75 + i);
                BackWheel = DrawWheel(BackWheel, 50 + i, 190, i / 3);
                FrontWheel = DrawWheel(FrontWheel, 240 + i, 190, i / 3);
                Lamp = DrawLamp(Lamp, 340 + i);
                RoofDecor = DrawRoofDecor(RoofDecor, i);
            }
        }

        public Graphics DrawCorp(Graphics shape, int x = 0, int y = 90)
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            int width = 350;
            int height = 100;
            shape.FillRectangle(blueBrush, x, y, width, height);
            return shape;
        }

        public Graphics DrawRoof(Graphics shape, int x = 75, int y = 0)
        {
            SolidBrush lightBlueBrush = new SolidBrush(Color.LightBlue);
            int width = 200;
            int height = 90;
            shape.FillRectangle(lightBlueBrush, x, y, width, height);
            return shape;
        }

        public Graphics DrawWheel(Graphics shape, int x = 50, int y = 190, int alpha = 0)
        {
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Pen grPen = new Pen(Color.Gray, 2);
            int width = 60;
            int height = 60;
            shape.FillEllipse(blackBrush, x, y, width, height);
            int x0 = x + 30;
            int y0 = y + 30;
            var pnt1 = GenerateNewPoint(x0, y0, x + 30, y, alpha);
            var pnt2 = GenerateNewPoint(x0, y0, x + 30, y + 60, alpha);
            var pnt3 = GenerateNewPoint(x0, y0, x, y + 30, alpha);
            var pnt4 = GenerateNewPoint(x0, y0, x + 60, y + 30, alpha);
            shape.DrawLine(grPen, pnt1, pnt2);
            shape.DrawLine(grPen, pnt3, pnt4);

            return shape;
        }

        public Graphics DrawLamp(Graphics shape, int x = 340, int y = 120)
        {
            SolidBrush yellkBrush = new SolidBrush(Color.Yellow);
            int width = 20;
            int height = 46;
            shape.FillEllipse(yellkBrush, x, y, width, height);
            return shape;
        }

        public Graphics DrawRoofDecor(Graphics shape, int offsetX = 0)
        {
            Pen blPen = new Pen(Color.Blue, 4);
            Point p1 = new Point(175 + offsetX, 0);
            Point p2 = new Point(175 + offsetX, 90);
            Point p3 = new Point(75 + offsetX, 90);
            Point p4 = new Point(75 + offsetX, 0);
            Point p5 = new Point(275 + offsetX, 0);
            Point p6 = new Point(275 + offsetX, 90);
            shape.DrawLine(blPen, p1, p2);
            shape.DrawLine(blPen, p3, p4);
            shape.DrawLine(blPen, p4, p5);
            shape.DrawLine(blPen, p5, p6);
            return shape;
        }

        private static Point GenerateNewPoint(int x0, int y0, int x, int y, int alpha = 0)
        {
            double nX = x0 + (x - x0) * Math.Cos(alpha) - (y - y0) * Math.Sin(alpha);
            double nY = y0 + (y - y0) * Math.Cos(alpha) + (x - x0) * Math.Sin(alpha);
            return new Point((int)nX, (int)nY);
        }



    }
}
