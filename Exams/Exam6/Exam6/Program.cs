using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam6
{
    class fun
    {
        double x;

        public fun(double value)
        {
            x = value;
        }

        public double Func()
        {
            return Math.Cos(2 * x) + Math.Sin(x - 3);
        }

        public double Fx
        {
            get { return x; }
            set { x = value; }
        }
    }
    class Program
    {
        public static void Main()
        {
            fun a = new fun(5);
            fun b = new fun(-10);

            double fa = a.Func();
            double fb = b.Func();
            Console.WriteLine("FUNCTION AT POINT A TAKES VALUE: " + fa);
            Console.WriteLine("FUNCTION AT POINT B TAKES VALUE: " + fb);
            if (fa > fb) Console.WriteLine("POINT b IS LESS THAN POINT a IN THE FUNCTION IN CONSIDERATION");
            else if (fa < fb) Console.WriteLine("POINT a IS LESS THAN POINT b IN THE FUNCTION IN CONSIDERATION");
            else Console.WriteLine("POINT a IS EQUAL TO POINT b IN THE FUNCTION IN CONSIDERATION");
            Console.ReadLine();
        }
    }
}
