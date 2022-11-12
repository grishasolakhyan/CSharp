using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(SystemColors.Window);
            Pen p = new Pen(Color.Black, 1);

            double x = 254, y = 490;
            int a = 100;

            double alpha = 180;
            double phi = 0;
            double ang = 0;

            for (int i = 0; i < 5; i++)
            {
                double x1 = 0, x2 = 0, x3 = 0, x4 = 0, y1 = 0, y2 = 0, y3 = 0, y4 = 0;

                x1 = x + a * Math.Cos((alpha) * Math.PI / 180);
                y1 = y + a * Math.Sin((alpha) * Math.PI / 180);

                x2 = x1 + a * Math.Sin(phi * Math.PI / 180) / Math.Sin(90 * Math.PI / 180);
                y2 = y1 - a * Math.Sin((90 - phi) * Math.PI / 180) / Math.Sin(90 * Math.PI / 180);

                x3 = x2 - a * Math.Cos((alpha) * Math.PI / 180);
                y3 = y2 - a * Math.Sin((alpha) * Math.PI / 180);


                x4 = x3 + a / 2 * Math.Cos((alpha + phi) * Math.PI / 180);
                y4 = y3 - a / 2 * Math.Sin((phi + ang) * Math.PI / 180) / Math.Sin((90 - ang) * Math.PI / 180);

                int ix = Convert.ToInt32(x);
                int iy = Convert.ToInt32(y);

                int ix1 = Convert.ToInt32(x1);
                int iy1 = Convert.ToInt32(y1);

                int ix2 = Convert.ToInt32(x2);
                int iy2 = Convert.ToInt32(y2);

                int ix3 = Convert.ToInt32(x3);
                int iy3 = Convert.ToInt32(y3);

                int ix4 = Convert.ToInt32(x4);
                int iy4 = Convert.ToInt32(y4);

                Point p1 = new Point(ix, iy);
                Point p2 = new Point(ix1, iy1);
                Point p3 = new Point(ix2, iy2);
                Point p4 = new Point(ix3, iy3);
                Point p5 = new Point(ix4, iy4);

                gr.DrawLine(p, p1, p2);
                gr.DrawLine(p, p2, p3);
                gr.DrawLine(p, p3, p4);
                gr.DrawLine(p, p4, p1);
                gr.DrawLine(p, p4, p5);
                gr.DrawLine(p, p5, p3);

                double xm = Convert.ToInt32((x2 + x3) / 2);
                double ym = Convert.ToInt32((y2 + y3) / 2);

                double d = Math.Sqrt(Math.Pow(Math.Abs(x4 - xm), 2) + Math.Pow(Math.Abs(y4 - ym), 2));
                double ad = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(d, 2));
                a = Convert.ToInt32(ad);

                //Console.WriteLine("phi=" + phi + " " +  "ang=" + ang + " " + "alpha=" + alpha);
                //Console.WriteLine("x4=" + a / 2 * Math.Cos((alpha + phi) * Math.PI / 180) + " " + "y4=" + a / 2 * Math.Sin((phi + ang) * Math.PI / 180) / Math.Sin((90 - 45) * Math.PI / 180));

                x = x3;
                y = y3;
                phi += ang;
                alpha = alpha + ang;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = hScrollBar1.Value.ToString();
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(SystemColors.Window);
            Pen p = new Pen(Color.Black, 1);

            double x = 254, y = 490;
            string a_s = label1.Text;
            int a = 100;

            double alpha = 180;
            double phi = 0;
            double ang = Convert.ToDouble(a_s);

            for (int i = 0; i < 6; i++)
            {
                double x1 = 0, x2 = 0, x3 = 0, x4 = 0, y1 = 0, y2 = 0, y3 = 0, y4 = 0;

                x1 = x + a * Math.Cos((alpha) * Math.PI / 180);
                y1 = y + a * Math.Sin((alpha) * Math.PI / 180);

                x2 = x1 + a * Math.Sin(phi * Math.PI / 180) / Math.Sin(90 * Math.PI / 180);
                y2 = y1 - a * Math.Sin((90 - phi) * Math.PI / 180) / Math.Sin(90 * Math.PI / 180);

                x3 = x2 - a * Math.Cos((alpha) * Math.PI / 180);
                y3 = y2 - a * Math.Sin((alpha) * Math.PI / 180);

                x4 = x3 + a / 2 * Math.Cos((alpha + phi) * Math.PI / 180);
                y4 = y3 - a / 2 * Math.Sin((phi + ang) * Math.PI / 180) / Math.Sin((90 - ang) * Math.PI / 180);

                int ix = Convert.ToInt32(x);
                int iy = Convert.ToInt32(y);

                int ix1 = Convert.ToInt32(x1);
                int iy1 = Convert.ToInt32(y1);

                int ix2 = Convert.ToInt32(x2);
                int iy2 = Convert.ToInt32(y2);

                int ix3 = Convert.ToInt32(x3);
                int iy3 = Convert.ToInt32(y3);

                int ix4 = Convert.ToInt32(x4);
                int iy4 = Convert.ToInt32(y4);


                Point p1 = new Point(ix, iy);
                Point p2 = new Point(ix1, iy1);
                Point p3 = new Point(ix2, iy2);
                Point p4 = new Point(ix3, iy3);
                Point p5 = new Point(ix4, iy4);


                gr.DrawLine(p, p1, p2);
                gr.DrawLine(p, p2, p3);
                gr.DrawLine(p, p3, p4);
                gr.DrawLine(p, p4, p1);
                gr.DrawLine(p, p4, p5);
                gr.DrawLine(p, p5, p3);

                double xm = Convert.ToInt32((x2 + x3) / 2);
                double ym = Convert.ToInt32((y2 + y3) / 2);

                double d = Math.Sqrt(Math.Pow(Math.Abs(x4 - xm), 2) + Math.Pow(Math.Abs(y4 - ym), 2));
                double ad = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(d, 2));
                a = Convert.ToInt32(ad);

                //Console.WriteLine("phi=" + phi + " " +  "ang=" + ang + " " + "alpha=" + alpha);
                //Console.WriteLine("x4=" + a / 2 * Math.Cos((alpha + phi) * Math.PI / 180) + " " + "y4=" + a / 2 * Math.Sin((phi + ang) * Math.PI / 180) / Math.Sin((90 - 45) * Math.PI / 180));

                x = x3;
                y = y3;
                phi += ang;
                alpha = alpha + ang;
            }
        }
    }
}
