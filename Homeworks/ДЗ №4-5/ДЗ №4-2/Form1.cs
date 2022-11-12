using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ__4_2
{
    public partial class Form1 : Form
    {
        bool is_painted = false;

        Pen blackPen = new Pen(Color.Black, 1);
        Pen redPen = new Pen(Color.Red, 1);

        int n = 10;
        double min_r = 0.25, max_r = 1.0;
        double min_w = 1.0, max_w = 10.0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = 20;
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = 10;
            Draw();
        }
        private void Draw()
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Pen blackPen = new Pen(Color.Black, 1);
            Pen redPen = new Pen(Color.Red, 1);

            double[] r = new double[n];
            for (int i = 0; i < n; i++)
            {
                r[i] = rand.NextDouble() * (max_r - min_r) + min_r;
            }

            double[] w = new double[n];
            double total_w = 0;
            for (int i = 0; i < n; i++)
            {
                w[i] = rand.NextDouble() * (max_w - min_w) + min_w;
                total_w += w[i];
            }

            double[] a = new double[n];
            double to_rad = 2 * Math.PI / total_w;
            for (int i = 0; i < n; i++)
            {
                a[i] = w[i] * to_rad;
            }

            PointF[] points = new PointF[n];
            float rx = pictureBox1.Width / 2, ry = pictureBox1.Height / 2;
            float cx = pictureBox1.Width / 2, cy = pictureBox1.Height / 2;

            double theta = 0;
            for (int i = 0; i < n; i++)
            {
                points[i] = new PointF(
                    cx + (float)(rx * r[i] * Math.Cos(theta)),
                    cy + (float)(ry * r[i] * Math.Sin(theta)));
                theta += a[i];
            }

            Array.Reverse(points, 0, points.Length);
            List<PointF> points_list = new List<PointF>(points);

            SolidBrush backBrush = new SolidBrush(Color.DarkMagenta);
            g.FillPolygon(backBrush, points);

            Analysis(points_list, g);

            is_painted = true;
        }
        private void Analysis(List<PointF> points, Graphics g)
        {
            List<Color> colors = new List<Color>();
            for (int i = 0; i < n + 1; i++)
                colors.Add(Color.FromArgb(rand.Next(25, 225), rand.Next(25, 225), rand.Next(25, 225)));

            if (points.Count > 3)
            {
                List<PointF> points_list = new List<PointF>();
                List<int> test = new List<int>();

                int i = 0;
                while (i < points.Count - 2)
                {
                    if (isLeft(points[i], points[i + 1], points[i + 2]))
                    {
                        //g.DrawLine(redPen, points[i], points[i + 2]);
                        SolidBrush randBrush = new SolidBrush(colors[0]);

                        PointF[] polygon_to_drow = { points[i], points[i + 1], points[i + 2] };
                        g.FillPolygon(randBrush, polygon_to_drow);

                        colors.RemoveAt(0);

                        points_list.Add(points[i]);
                        points_list.Add(points[i + 2]);

                        i += 2;
                    }
                    else
                    {
                        points_list.Add(points[i + 1]);
                        i++;
                    }
                }

                points_list.Add(points[0]);
                points_list.Add(points[points.Count - 1]);

                List<PointF> uniqueList = points_list.Distinct().ToList();

                Analysis(uniqueList, g);
            }
            //Console.WriteLine(points.Count);
        }
        private bool isLeft(PointF a, PointF b, PointF c) //левая ли тройка векторов
        {
            float abX = b.X - a.X;
            float abY = b.Y - a.Y;
            float acX = c.X - a.X;
            float acY = c.Y - a.Y;

            return abX * acY - acX * abY < 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
        }
    }
}
