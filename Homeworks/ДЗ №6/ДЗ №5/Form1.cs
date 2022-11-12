using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ__5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Point to2D(Point3D val)
        {
            double rx = -val.z * Math.Sin(1) + val.x * Math.Cos(1) + pictureBox1.Width / 2;
            double ry = -(val.z * Math.Cos(1) + val.x * Math.Sin(1)) * Math.Sin(1) + val.y * Math.Cos(1) + pictureBox1.Height / 2;

            return new Point((int)rx, (int)ry);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 2);

            List<Point3D> cube = new List<Point3D>();

            cube.Add(new Point3D(-150, -150, -150));
            cube.Add(new Point3D(150, -150, -150));
            cube.Add(new Point3D(150, -150, 150));
            cube.Add(new Point3D(-150, -150, 150));
            cube.Add(new Point3D(-150, 150, 150));
            cube.Add(new Point3D(-150, 150, -150));
            cube.Add(new Point3D(-150, -150, 150));
            cube.Add(new Point3D(-150, -150, -150));
            cube.Add(new Point3D(-150, 150, -150));
            cube.Add(new Point3D(150, 150, -150));
            cube.Add(new Point3D(150, 150, 150));
            cube.Add(new Point3D(150, -150, 150));
            cube.Add(new Point3D(150, -150, -150));
            cube.Add(new Point3D(150, 150, -150));
            cube.Add(new Point3D(-150, 150, -150));
            cube.Add(new Point3D(-150, 150, 150));
            cube.Add(new Point3D(150, 150, 150));
            cube.Add(new Point3D(150, 150, 150));

            for (int i = 0; i < cube.Count - 1; i++)
            {
                if (i != cube.Count - 2)
                {
                    g.DrawLine(blackPen, to2D(cube[i]), to2D(cube[i + 1]));
                    Thread.Sleep(50);
                }
            }
        }
    }
    public class Point3D
    {
        public float x { set; get; }
        public float y { set; get; }
        public float z { set; get; }

        public Point3D(int x1, int y1, int z1)
        {
            x = x1 / 1.5f;
            y = y1 / 1.5f;
            z = z1 / 1.5f;
        }
    }
}
