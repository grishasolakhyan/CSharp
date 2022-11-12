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
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Form form = new Form();
            form.Text = "Hello, World!";
            form.Visible = true;
            form.BackColor = Color.BlanchedAlmond;
            form.Width += 2;
            form.Height /= 2;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = true;
            form.Cursor = Cursors.Hand; // 
            form.StartPosition = FormStartPosition.CenterScreen;

            Application.Run(form);
        }
    }
}