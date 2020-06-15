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
    public partial class SecondExForm : Form
    {
        public SecondExForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            SolidBrush orangBrush = new SolidBrush(Color.Orange);
            Graphics gEllips = Graphics.FromHwnd(pictureBox1.Handle);
            int x = 140;
            int y = 140;
            int width = 160;
            int height = 160;
            gEllips.FillEllipse(orangBrush, x, y, width, height);

            SolidBrush brownBrush = new SolidBrush(Color.Brown);
            Pen pen = new Pen(Color.Brown, 5);
            Graphics gTriangles = Graphics.FromHwnd(pictureBox1.Handle);
            Point p1 = new Point(223, 150);
            Point p2 = new Point(220, 150);
            Point p3 = new Point(221, 157);
            gTriangles.DrawLine(pen, p1, p2);
            gTriangles.DrawLine(pen, p1, p3);
            gTriangles.DrawLine(pen, p2, p3);
        }
    }
}
