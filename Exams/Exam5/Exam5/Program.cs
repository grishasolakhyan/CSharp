using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("SELECT A TASK:" +
                "\n1)RECTANGLE" +
                "\n2)CIRCLE");

                num = (char)Console.Read();
            if (num >= 1 || num <= 2)
            {
                Console.ReadLine();
                switch (num)
                {
                    case '1':
                        Console.WriteLine("ENTER SIDES OF RECTANGLE:");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("SIDE A=" + a + "\n");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("SIDE B=" + b + "\n");
                        double per = 2 * a + 2 * b;
                        double sq1 = a * b;
                        Console.WriteLine("PERIMETER OF A RECTANGLE IS: " + per);
                        Console.WriteLine("AREA OF THE RECTANGLE IS: " + sq1);
                        Console.ReadLine();
                        break;
                    case '2':
                        Console.WriteLine("ENTER CIRCLE RADIUS: ");
                        double r = double.Parse(Console.ReadLine());
                        double pi = 3.1415926535;
                        double sq2 = pi * r * r;
                        double leng = 2 * pi * r;
                        Console.WriteLine("CIRCLE LENGTH IS: " + leng);
                        Console.WriteLine("THE AREA OF A CIRCLE IS: " + sq2);
                        Console.ReadLine();
                        break;
                }
            }
            else Console.WriteLine("INCORRECT TASK NUMBER SELECTED");
            Console.ReadLine();
        }
    }
}
