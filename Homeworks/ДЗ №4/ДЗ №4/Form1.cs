using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ__4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void built_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(label2.Text);
            int[,] stx = built_Xdots(N);
            built_polygon(stx, N);
        }
        public int[,] built_Xdots(int N)
        {
            int x0 = pictureBox1.Width / 2;
            int y0 = pictureBox1.Height / 2;
            int r = 0;
            int alpha = 0;
            int phi = 0;

            int[,] x_coords = new int[N, 2];

            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                phi = 0;
                phi = rnd.Next(360 / N, 360 / N);
                r = rnd.Next(100, 200);
                alpha += phi;

                double xd = x0 + r * Math.Cos(alpha * Math.PI / 180);
                double yd = y0 + r * Math.Sin(alpha * Math.PI / 180);

                x_coords[i, 0] = Convert.ToInt32(xd);
                x_coords[i, 1] = Convert.ToInt32(yd);
            }
            return x_coords;
        }

        public void built_polygon(int[,] stx, int N)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(SystemColors.Window);
            Pen p = new Pen(Color.Black, 1);

            int xo1 = 0;
            int yo1 = 0;
            int xo2 = 0;
            int yo2 = 0;

            for (int i = 0; i < N - 1; i++)
            {
                int x1 = stx[i, 0];
                int y1 = stx[i, 1];

                int x2 = stx[i + 1, 0];
                int y2 = stx[i + 1, 1];

                PointF p1 = new PointF(x1, y1);
                PointF p2 = new PointF(x2, y2);

                gr.DrawLine(p, p1, p2);

                if (i == 0)
                {
                    xo1 = x1;
                    yo1 = y1;
                }
                if (i == N - 2)
                {
                    xo2 = x2;
                    yo2 = y2;
                }
                if (i == N - 2)
                {
                    PointF p11 = new PointF(xo1, yo1);
                    PointF p22 = new PointF(xo2, yo2);
                    gr.DrawLine(p, p11, p22);
                }
            }
        }
        public void split_polydon(int N)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(SystemColors.Window);
            Pen p = new Pen(Color.Black, 1);

            int[,] x_co = built_Xdots(N);
            int l = x_co.GetLength(0);

            for (int i = 0; i < l - 2; i += 2)
            {
                PointF p1 = new PointF(x_co[i, 0], x_co[i, 1]);
                PointF p2 = new PointF(x_co[i + 1, 0], x_co[i + 1, 1]);
                PointF p3 = new PointF(x_co[i + 2, 0], x_co[i + 2, 1]);
                PointF[] dots =
                {
                    p1, p2, p3
                };
                gr.FillPolygon(Brushes.Red, dots);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(label2.Text);
            split_polydon(N);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = hScrollBar1.Value.ToString();
        }
    }
}
