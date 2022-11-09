using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ЗАДАЙТЕ КООРДИНАТУ x:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = x1;

            Console.Write("ЗАДАННОЕ ЗНАЧЕНИЕ X=" + x1 + "\n");
            Console.Write("ЗАДАННОЕ ЗНАЧЕНИЕ Y=" + y1 + "\n");

            Console.Write("КООРДИНАТЫ ТОЧКИ: " + "\n");
            Console.Write("X=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y=");
            double y = double.Parse(Console.ReadLine());

            if ((y == 0) && ((x >= 0) && (x <= x1)))
            {
                Console.Write("КОНТУР" + "\n");
            }
            else if ((x == x1) && ((y <= y1)&&(y>=0)))
            {
                Console.Write("КОНТУР" + "\n");
            }
            else if ((y == x) && ((x >= 0) && (x <= x1)))
            {
                Console.Write("КОНТУР" + "\n");
            }
            else if (((y > 0) && (y < x)) && ((x > 0) && (x < x1)))
            {
                Console.Write("В ОБЛАСТИ" + "\n");
            }
            else if((x>x1)||(x<0)||(y<0))
            {
                Console.Write("ВНЕ ОБЛАСТИ" + "\n");
            }
            else if((x>=0)&&(x<x1)&&(y>x)&&(y<y1))
            {
                Console.Write("ВНЕ ОБЛАСТИ"+"\n");
            }

        }
    }
}
