using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

class mypic
{
    public static void Main()
    {
        MessageBox.Show(
            Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "My pictures");
    }
}