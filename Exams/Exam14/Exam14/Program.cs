using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam14
{
    class Triangle
    {
        public double a, b, c, Per, Sq;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public virtual bool Exist()
        {
            return ((a + b < c) || (b + c > a) || (c + a > b));
        }
        public void show()
        {
            Console.WriteLine("SIDE 1=" + a);  
            Console.WriteLine("SIDE 2=" + b);
            Console.WriteLine("SIDE 3=" + c);
        }
        public virtual double Perimetr()
        {
            Per = a + b + c;
            Console.WriteLine("PERIMETER OF A TRIANGLE IS EQUAL:" + Per);
            return Per;
        }
        public virtual double Square()
        {
            double Sq = Math.Sqrt(Per * (Per - a) * (Per - b) * (Per - c));
            Console.WriteLine("THE AREA OF THE TRIANGLE IS EQUAL:" + Sq);
            return Sq;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(-5,3,4);
            t1.show();
            t1.Perimetr();
            t1.Square();
            Console.ReadLine();
        }
    }
}
