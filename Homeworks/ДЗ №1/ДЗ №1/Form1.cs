using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        public void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(SystemColors.Window);
            Pen p = new Pen(Color.Blue, 2);

            string x1s = null, x2s = null, y1s = null, y2s = null;
            string angle_s;
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            double d1, d2;
            int angle=0;
            double d, c1, c2;

            int beta=0;
            int gamma=0;
            int delta=0;
            int epsilon=0;

            x1s = textBox1.Text;
            x2s = textBox4.Text;
            y1s = textBox2.Text;
            y2s = textBox3.Text;

            if (x1s.Length == 0)
            {
                x1s = "249";
            }
            if (x2s.Length == 0)
            {
                x2s = "394";
            }
            if (y1s.Length == 0)
            {
                y1s = "249";
            }
            if (y2s.Length == 0)
            {
                y2s = "249";
            }

            x1 = Convert.ToInt32(x1s);
            x2 = Convert.ToInt32(x2s);
            y1 = Convert.ToInt32(y1s);
            y2 = Convert.ToInt32(y2s);

            d = Math.Sqrt(Math.Pow(Math.Abs(x2 - x1), 2) + Math.Pow(Math.Abs(y2 - y1), 2));
            d1 = Convert.ToInt32(d);
            label7.Text = Convert.ToString(d1);
            angle_s = textBox5.Text;

            if (angle_s.Length == 0)
            {
                angle = 0;
            }
            else
            {
                angle = Convert.ToInt32(angle_s);
            }

            if (angle!=0 && angle!=360)
            {
                int angle180 = angle;
                if (angle>90 && angle < 180)
                {
                    angle = 180 - angle;
                }
                else if (angle > 180 && angle < 270)
                {
                    angle = angle - 180;
                }
                else if (angle > 270 && angle < 360)
                {
                    angle = 360 - angle;
                }
                beta = (180 - angle) / 2;
                gamma = beta;
                delta = 90 - beta;
                epsilon = 180 - 90 - delta;
                d2 = Math.Sqrt(d1 * d1 + d1 * d1 - 2 * d1 * d1 * Math.Cos(angle * Math.PI / 180));
                c1 = Math.Round(d2 * Math.Sin(epsilon * Math.PI / 180) / Math.Sin(90 * Math.PI / 180));
                c2 = Math.Round(d2 * Math.Sin(delta * Math.PI / 180) / Math.Sin(90 * Math.PI / 180));
                int c11=Convert.ToInt32(c1), c22=Convert.ToInt32(c2), d11=Convert.ToInt32(d1);
                
                if (angle180 > 0 && angle180 <= 90)
                {
                    x2 = x2 - c22;
                    y2 = y2 - c11;
                }
                else if (angle180 > 90 && angle180 < 180)
                {
                    x2 = x2 - 2*d11 + c22;
                    y2 = y2 - c11;
                }
                else if (angle180 == 180)
                {
                    x2 = x2 - 2 * d11;
                }
                else if (angle180 > 180 && angle180 < 270)
                {
                    x2 = x2 - 2 * d11 + c22;
                    y2 = y2 + c11;
                }
                else if (angle180 == 270)
                {
                    x2 = x2 - d11;
                    y2 = y2 + d11;
                }
                else if (angle180 > 270 && angle180 < 360)
                {
                    x2 = x2 - c22;
                    y2 = y2 + c11;
                }               
                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);
                gr.DrawLine(p, p1, p2);
            }
            else
            {                
                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);
                gr.DrawLine(p, p1, p2);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | (e.KeyChar == '\b') | (Char.IsPunctuation(e.KeyChar))) return;
            else e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | (e.KeyChar == '\b') | (Char.IsPunctuation(e.KeyChar))) return;
            else e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | (e.KeyChar == '\b') | (Char.IsPunctuation(e.KeyChar))) return;
            else e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | (e.KeyChar == '\b') | (Char.IsPunctuation(e.KeyChar))) return;
            else e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | (e.KeyChar == '\b') | (Char.IsPunctuation(e.KeyChar))) return;
            else e.Handled = true;
        }

        private void Angle_Scroll(object sender, ScrollEventArgs e)
        {
            textBox5.Text = Angle.Value.ToString();
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(SystemColors.Window);
            Pen p = new Pen(Color.Blue, 2);

            string x1s = null, x2s = null, y1s = null, y2s = null;
            string angle_s;
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            double d1, d2;
            int angle = 0;
            double d, c1, c2;

            int beta = 0;
            int gamma = 0;
            int delta = 0;
            int epsilon = 0;

            x1s = textBox1.Text;
            x2s = textBox4.Text;
            y1s = textBox2.Text;
            y2s = textBox3.Text;

            if (x1s.Length == 0)
            {
                x1s = "249";
            }
            if (x2s.Length == 0)
            {
                x2s = "394";
            }
            if (y1s.Length == 0)
            {
                y1s = "249";
            }
            if (y2s.Length == 0)
            {
                y2s = "249";
            }

            x1 = Convert.ToInt32(x1s);
            x2 = Convert.ToInt32(x2s);
            y1 = Convert.ToInt32(y1s);
            y2 = Convert.ToInt32(y2s);

            d = Math.Sqrt(Math.Pow(Math.Abs(x2 - x1), 2) + Math.Pow(Math.Abs(y2 - y1), 2));
            d1 = Convert.ToInt32(d);
            label7.Text = Convert.ToString(d1);
            angle_s = textBox5.Text;

            if (angle_s.Length == 0)
            {
                angle = 0;
            }
            else
            {
                angle = Convert.ToInt32(angle_s);
            }

            if (angle != 0 && angle != 360)
            {
                int angle180 = angle;
                if (angle > 90 && angle < 180)
                {
                    angle = 180 - angle;
                }
                else if (angle > 180 && angle < 270)
                {
                    angle = angle - 180;
                }
                else if (angle > 270 && angle < 360)
                {
                    angle = 360 - angle;
                }
                beta = (180 - angle) / 2;
                gamma = beta;
                delta = 90 - beta;
                epsilon = 180 - 90 - delta;
                d2 = Math.Sqrt(d1 * d1 + d1 * d1 - 2 * d1 * d1 * Math.Cos(angle * Math.PI / 180));
                c1 = Math.Round(d2 * Math.Sin(epsilon * Math.PI / 180) / Math.Sin(90 * Math.PI / 180));
                c2 = Math.Round(d2 * Math.Sin(delta * Math.PI / 180) / Math.Sin(90 * Math.PI / 180));
                int c11 = Convert.ToInt32(c1), c22 = Convert.ToInt32(c2), d11 = Convert.ToInt32(d1);

                if (angle180 > 0 && angle180 <= 90)
                {
                    x2 = x2 - c22;
                    y2 = y2 - c11;
                }
                else if (angle180 > 90 && angle180 < 180)
                {
                    x2 = x2 - 2 * d11 + c22;
                    y2 = y2 - c11;
                }
                else if (angle180 == 180)
                {
                    x2 = x2 - 2 * d11;
                }
                else if (angle180 > 180 && angle180 < 270)
                {
                    x2 = x2 - 2 * d11 + c22;
                    y2 = y2 + c11;
                }
                else if (angle180 == 270)
                {
                    x2 = x2 - d11;
                    y2 = y2 + d11;
                }
                else if (angle180 > 270 && angle180 < 360)
                {
                    x2 = x2 - c22;
                    y2 = y2 + c11;
                }
                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);
                gr.DrawLine(p, p1, p2);
            }
            else
            {
                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);
                gr.DrawLine(p, p1, p2);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
