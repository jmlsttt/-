using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int x1, y1;
        private int a=-1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            y1 -= 20;
            Invalidate();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2+180;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        SolidBrush B = new SolidBrush(Color.Gray);
        SolidBrush G = new SolidBrush(Color.DarkRed);
        SolidBrush K = new SolidBrush(Color.SkyBlue);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(B, x1-100, y1-100, 50, 50);
            g.FillRectangle(B, x1 - 100, y1 -70, 50, 100);
            g.FillRectangle(G, x1 - 120, y1, 20, 40);
            g.FillRectangle(G, x1 - 50, y1, 20, 40);
            g.FillEllipse(K, x1 - 90, y1 -50 , 30, 30);
        }


        public Form1()
        {
            InitializeComponent();
        }
    }
}
