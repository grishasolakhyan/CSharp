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
            Console.Write("Enter the surface area of the cube: ");
            int pov = Convert.ToInt32(Console.ReadLine());
            double square=pov/6;
            Console.WriteLine("The area of the face is: " + square);
            double reb = Math.Sqrt(square);
            Console.WriteLine("The edge length of the cube is " + reb);
            Console.ReadLine();
        }
    }
}
