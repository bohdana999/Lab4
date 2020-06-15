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
    public partial class ThirdExForm : Form
    {
        private Random _random;
        public Graphics Line { get; set; }
        public ThirdExForm()
        {
            _random = new Random();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Line = DrawLine(Graphics.FromHwnd(pictureBox1.Handle), GenerateSimplePoint(), GenerateSimplePoint());
        }

        public Graphics DrawLine(Graphics shape, Point point1, Point point2)
        {
            Pen blPen = new Pen(Color.Black, 4);
            shape.DrawLine(blPen, point1, point2);
            var randX = _random.Next(Math.Min(point1.X, point2.X), Math.Max(point1.X, point2.X));
            Point p0 = new Point(randX, LineFunction(randX));

            for (var i = 0; i < 200; i++)
            {
                Thread.Sleep(50);
                if (_random.Next() % 3 == 0)
                {
                    blPen.Color = RandomColor();
                }
                shape.Clear(BackColor);
                point1 = GenerateNewPoint(p0, point1, i);
                point2 = GenerateNewPoint(p0, point2, i);
                shape.DrawLine(blPen, point1, point2);
            }


            return shape;

        }

        private Color RandomColor()
        {
            return Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
        }

        private Point GenerateSimplePoint(int min = 200, int max = 500)
        {
            var x = _random.Next(min, max);
            return new Point(x, LineFunction(x));
        }

        private static int LineFunction(int x)
        {
            return (int)(480 - 0.6 * x);
        }
        
        private static Point GenerateNewPoint(Point p0, Point p, double alpha = 0)
        {
            return GenerateNewPoint(p0.X, p0.Y, p.X, p.Y, alpha);
        }

        private static Point GenerateNewPoint(int x0, int y0, int x, int y, double alpha = 0)
        {
            double nX = x0 + (x - x0) * Math.Cos(alpha) - (y - y0) * Math.Sin(alpha);
            double nY = y0 + (y - y0) * Math.Cos(alpha) + (x - x0) * Math.Sin(alpha);
            return new Point((int)nX, (int)nY);
        }
    }
}
