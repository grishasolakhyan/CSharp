using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _2_3
{
    static class programm
    {
        static void Main()
        {
            Form form = new Form();
            form.Text = "Hello";
            form.Paint += new PaintEventHandler(MyPaintHandler);
            Application.Run(form);
        }
        static void MyPaintHandler(object objSender, PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;
            grfx.Clear(Color.White);
            grfx.DrawString("Hello", new Font("Impact", 25, FontStyle.Regular),
            new SolidBrush(Color.Black),
            new PointF(10,10));
        }
    }
}