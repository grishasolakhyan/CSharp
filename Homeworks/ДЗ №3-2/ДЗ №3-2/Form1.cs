using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ__3_2
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
            draw_tree(pictureBox1.Width / 2.5, pictureBox1.Height, 90, 0);
        }
        public void draw_tree(double x, double y, double r, double a)
        {
            if (r > 8)
            {
                draw_rect(x, y, r, a);

                draw_tree(
                    x - r * Math.Sin(a),
                    y - r * Math.Cos(a),
                    r / Math.Sqrt(2),
                    a + Math.PI / 4
                );

                draw_tree(
                    x - r * Math.Sin(a) + r / Math.Sqrt(2) * Math.Cos(a + Math.PI / 4),
                    y - r * Math.Cos(a) - r / Math.Sqrt(2) * Math.Sin(a + Math.PI / 4),
                    r / Math.Sqrt(2),
                    a - Math.PI / 4
                );
            }
        }

        public void draw_rect(double x1, double y1, double r, double a)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);

            double x2 = Math.Round(x1 + (r * Math.Cos(a)));
            double y2 = Math.Round(y1 - (r * Math.Sin(a)));

            double x3 = Math.Round(x1 + (r * Math.Sqrt(2) * Math.Cos(a + Math.PI / 4)));
            double y3 = Math.Round(y1 - (r * Math.Sqrt(2) * Math.Sin(a + Math.PI / 4)));

            double x4 = Math.Round(x1 + (r * Math.Cos(a + Math.PI / 2)));
            double y4 = Math.Round(y1 - (r * Math.Sin(a + Math.PI / 2)));

            g.DrawLine(pen, (int)x1, (int)y1, (int)x2, (int)y2);
            g.DrawLine(pen, (int)x2, (int)y2, (int)x3, (int)y3);
            g.DrawLine(pen, (int)x3, (int)y3, (int)x4, (int)y4);
            g.DrawLine(pen, (int)x4, (int)y4, (int)x1, (int)y1);
        }
    }
}
