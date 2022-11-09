using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите площадь поверхности куба: ");
            int pov = Convert.ToInt32(Console.ReadLine());
            double square=pov/6;
            Console.WriteLine("Площадь грани равна: " + square);
            double reb = Math.Sqrt(square);
            Console.WriteLine("Длина ребра куба равна " + reb);
            Console.ReadLine();
        }
    }
}
