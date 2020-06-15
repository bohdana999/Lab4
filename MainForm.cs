using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ex1_Click(object sender, EventArgs e)
        {
            var firstExForm = new FirstExForm();
            firstExForm.Show();
        }

        private void ex2_Click(object sender, EventArgs e)
        {
            var secondExForm = new SecondExForm();
            secondExForm.Show();
        }

        private void ex3_Click(object sender, EventArgs e)
        {
            var thirdExForm = new ThirdExForm();
            thirdExForm.Show();
        }

        private void ex4_Click(object sender, EventArgs e)
        {
            var fourthExForm = new FourthExForm();
            fourthExForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

 }

