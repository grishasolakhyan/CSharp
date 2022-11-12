using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x1s, x2s, y1s, y2s;
            int x11, x22, y11, y22;
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(SystemColors.Window);
            Pen p = new Pen(Color.Black, 1);

            x1s = label1.Text;
            x11 = Convert.ToInt32(x1s);
            x2s = label2.Text;
            x22 = Convert.ToInt32(x2s);
            y1s = label3.Text;
            y11 = Convert.ToInt32(y1s);
            y2s = label4.Text;
            y22 = Convert.ToInt32(y2s);

            PointF px1 = new PointF(129, 174);
            PointF px2 = new PointF(369, 174);
            PointF px3 = new PointF(369, 324);
            PointF px4 = new PointF(129, 324);
            PointF[] curvePoints =
            {
                px1,px2,px3,px4
            };
            gr.FillPolygon(Brushes.Green, curvePoints);

            PointF px5 = new PointF(350, 74);
            PointF px6 = new PointF(409, 86);
            PointF px7 = new PointF(415, 170);
            PointF px8 = new PointF(389, 190);
            PointF[] curvePoints2 =
            {
                px5,px6,px7,px8
            };
            gr.FillPolygon(Brushes.Blue, curvePoints2);

            PointF px9 = new PointF(50, 406);
            PointF px10 = new PointF(139, 286);
            PointF px11 = new PointF(156, 470);
            PointF px12 = new PointF(145, 499);
            PointF[] curvePoints3 =
            {
                px9,px10,px11,px12
            };
            gr.FillPolygon(Brushes.Red, curvePoints3);

            PointF p11 = new PointF(x11, y11);
            PointF p22 = new PointF(x22, y11);
            PointF p33 = new PointF(x22, y22);
            PointF p44 = new PointF(x11, y22);
            PointF[] curvePointsX =
            {
                p11,p22,p33,p44
            };
            gr.DrawPolygon(p, curvePointsX);
        }

        private void x1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = x1.Value.ToString();

            string x1s, x2s, y1s, y2s;
            int x11, x22, y11, y22;
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(SystemColors.Window);
            Pen p = new Pen(Color.Black, 1);

            x1s = label1.Text;
            x11 = Convert.ToInt32(x1s);
            x2s = label2.Text;
            x22 = Convert.ToInt32(x2s);
            y1s = label3.Text;
            y11 = Convert.ToInt32(y1s);
            y2s = label4.Text;
            y22 = Convert.ToInt32(y2s);

            PointF p11 = new PointF(x11, y11);
            PointF p22 = new PointF(x22, y11);
            PointF p33 = new PointF(x22, y22);
            PointF p44 = new PointF(x11, y22);
            PointF[] curvePointsX =
            {
                p11,p22,p33,p44
            };
            gr.DrawPolygon(p, curvePointsX);
        }

        private void x2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = x2.Value.ToString();

            string x1s, x2s, y1s, y2s;
            int x11, x22, y11, y22;
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(SystemColors.Window);
            Pen p = new Pen(Color.Black, 1);

            x1s = label1.Text;
            x11 = Convert.ToInt32(x1s);
            x2s = label2.Text;
            x22 = Convert.ToInt32(x2s);
            y1s = label3.Text;
            y11 = Convert.ToInt32(y1s);
            y2s = label4.Text;
            y22 = Convert.ToInt32(y2s);

            PointF p11 = new PointF(x11, y11);
            PointF p22 = new PointF(x22, y11);
            PointF p33 = new PointF(x22, y22);
            PointF p44 = new PointF(x11, y22);
            PointF[] curvePointsX =
            {
                p11,p22,p33,p44
            };
            gr.DrawPolygon(p, curvePointsX);
        }

        private void y1_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = y1.Value.ToString();

            string x1s, x2s, y1s, y2s;
            int x11, x22, y11, y22;
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(SystemColors.Window);
            Pen p = new Pen(Color.Black, 1);

            x1s = label1.Text;
            x11 = Convert.ToInt32(x1s);
            x2s = label2.Text;
            x22 = Convert.ToInt32(x2s);
            y1s = label3.Text;
            y11 = Convert.ToInt32(y1s);
            y2s = label4.Text;
            y22 = Convert.ToInt32(y2s);

            PointF p11 = new PointF(x11, y11);
            PointF p22 = new PointF(x22, y11);
            PointF p33 = new PointF(x22, y22);
            PointF p44 = new PointF(x11, y22);
            PointF[] curvePointsX =
            {
                p11,p22,p33,p44
            };
            gr.DrawPolygon(p, curvePointsX);
        }

        private void y2_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = y2.Value.ToString();

            string x1s, x2s, y1s, y2s;
            int x11, x22, y11, y22;
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(SystemColors.Window);
            Pen p = new Pen(Color.Black, 1);

            x1s = label1.Text;
            x11 = Convert.ToInt32(x1s);
            x2s = label2.Text;
            x22 = Convert.ToInt32(x2s);
            y1s = label3.Text;
            y11 = Convert.ToInt32(y1s);
            y2s = label4.Text;
            y22 = Convert.ToInt32(y2s);

            PointF p11 = new PointF(x11, y11);
            PointF p22 = new PointF(x22, y11);
            PointF p33 = new PointF(x22, y22);
            PointF p44 = new PointF(x11, y22);
            PointF[] curvePointsX =
            {
                p11,p22,p33,p44
            };
            gr.DrawPolygon(p, curvePointsX);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x1s, x2s, y1s, y2s;
            int x11, x22, y11, y22;
            int nx1, nx2, ny1, ny2;
            Graphics gr = pictureBox1.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);

            x1s = label1.Text;
            x11 = Convert.ToInt32(x1s);
            x2s = label2.Text;
            x22 = Convert.ToInt32(x2s);
            y1s = label3.Text;
            y11 = Convert.ToInt32(y1s);
            y2s = label4.Text;
            y22 = Convert.ToInt32(y2s);

            nx1 = x11;
            nx2 = x22;
            ny1 = y11;
            ny2 = y22;

            if (x11<x22)
            {
                nx1 = x11;
                nx2 = x22;
            }
            else if(x11>x22)
            {
                nx1 = x22;
                nx2 = x11;
            }
            if (y11<y22)
            {
                ny1 = y11;
                ny2 = y22;
            }
            else if (y11>y22)
            {
                ny1 = y22;
                ny2 = y11;
            }

            PointF p11 = new PointF(0, 0);
            PointF p12 = new PointF(nx1, 0);
            PointF p13 = new PointF(nx1, 500);
            PointF p14 = new PointF(0, 500);
            PointF[] clear1 =
            {
                p11,p12,p13,p14
            };
            gr.FillPolygon(Brushes.White, clear1);

            PointF p21 = new PointF(nx1, 0);
            PointF p22 = new PointF(nx2, 0);
            PointF p23 = new PointF(nx2, ny1);
            PointF p24 = new PointF(nx1, ny1);
            PointF[] clear2 =
            {
                p21,p22,p23,p24
            };
            gr.FillPolygon(Brushes.White, clear2);

            PointF p31 = new PointF(nx1, ny2);
            PointF p32 = new PointF(nx2, ny2);
            PointF p33 = new PointF(nx2, 500);
            PointF p34 = new PointF(nx1, 500);
            PointF[] clear3 =
            {
                p31,p32,p33,p34
            };
            gr.FillPolygon(Brushes.White, clear3);

            PointF p41 = new PointF(nx2, 0);
            PointF p42 = new PointF(500, 0);
            PointF p43 = new PointF(500, 500);
            PointF p44 = new PointF(nx2, 500);
            PointF[] clear4 =
            {
                p41,p42,p43,p44
            };
            gr.FillPolygon(Brushes.White, clear4);

            PointF p51 = new PointF(x11, y11);
            PointF p52 = new PointF(x22, y11);
            PointF p53 = new PointF(x22, y22);
            PointF p54 = new PointF(x11, y22);
            PointF[] curvePointsX =
            {
                p51,p52,p53,p54
            };
            gr.DrawPolygon(p, curvePointsX);
        }
    }
}
