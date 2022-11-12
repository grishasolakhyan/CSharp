using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam15
{
    abstract class Figure
    {
        public abstract double Square();
        public abstract double Perimetr();
        public abstract void Info();
    }
    class Triangle : Figure
    {
        private readonly string name = "Triangle";
        private readonly double a, b, c;

        public bool Triangle_
        {
            get
            {

                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                return false;
            }
        }
        public Triangle(double a1, double b1, double c1)
        {
            this.a = a1;
            this.b = b1;
            this.c = c1;
        }
        public override double Perimetr()
        {
            return this.a + this.b + this.c;
        }
        public override double Square()
        {
            double p_2 = (this.a + this.b + this.c) / 2;
            return Math.Sqrt(p_2 * (p_2 - this.a) * (p_2 - this.b) * (p_2 - this.c));
        }
        public override void Info()
        {
            if (this.a + this.b <= this.c || this.a + this.c <= this.b || this.c + this.b <= this.a)
                System.Console.Write("\nThis reiangle does not exist!\n ");
            else if (this.a < 0 || this.b < 0 || this.c < 0)
                System.Console.Write("\nThe sides of a triangle cannot be negative.\n ");
            else
            {
                Console.WriteLine("\nShape name: {0} ", this.name);
                Console.WriteLine("Side a = " + this.a + "\nSide b = " + this.b + "\nSide c = " + this.c);
                Console.WriteLine("Perimeter = {0}", this.Perimetr());
                Console.WriteLine("Area = {0}", this.Square());
            }
        }
    }
    class Rectangle : Figure
    {
        private readonly string name = "Rectangle";

        private readonly double x, y;

        public bool Rectangle_
        {
            get
            {

                if (x != y && x > 0 && y > x)
                {
                    return true;
                }
                return false;
            }
        }
        public Rectangle(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override double Perimetr()
        {
            return (2 * x + 2 * y);
        }
        public override double Square()
        {
            return x * y;
        }
        public override void Info()
        {
            if (this.x < 0 || this.y < 0)
                System.Console.Write("\nThe sides of a triangle cannot be negative\n ");
            else
            {
                Console.WriteLine("\nShape name: {0} ", this.name);
                if (this.x == this.y)
                    System.Console.Write("\nThis rectangle is SQUARE\n");
                Console.WriteLine("Side x = " + this.x + "\nSide y = " + this.y);
                Console.WriteLine("Perimeter = {0}", this.Perimetr());
                Console.WriteLine("Area = {0}", this.Square());
            }

        }
    }
    class Circle : Figure
    {
        private readonly string name = "Circle";

        private readonly double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double Perimetr()
        {
            return Math.PI * 2 * this.r;
        }
        public override double Square()
        {
            return Math.PI * this.r * r;
        }
        public override void Info()
        {
            if (r < 0) System.Console.Write("\nCircle radius cannot be negative\n ");
            else
            {

                Console.WriteLine("\nShape name: {0}", this.name);
                Console.WriteLine("Radius r = " + this.r);
                Console.WriteLine("Perimeter = {0}", this.Perimetr());
                Console.WriteLine("Area = {0}", this.Square());
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string num;
                Console.WriteLine("CHOOSE A TASK:" +
                             "\n1)TRIANGLE" +
                             "\n2)RECTANGLE" +
                             "\n3)CIRCLE");
                Console.Write("\nTASK:");
                num = Console.ReadLine();
                if (num == "1")
                {
                    Console.Write("Side a=");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Side b=");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Side c=");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Figure f1 = new Triangle(a, b, c);
                    f1.Square();
                    f1.Perimetr();
                    f1.Info();
                }
                else if (num == "2")
                {
                    Console.Write("Side a=");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Side b=");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Figure f2 = new Rectangle(x, y);
                    f2.Square();
                    f2.Perimetr();
                    f2.Info();
                }
                else if (num == "3")
                {
                    Console.Write("Radius=");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Figure f3 = new Circle(r);
                    f3.Square();
                    f3.Perimetr();
                    f3.Info();
                }
                else
                {
                    Console.WriteLine("WRONG COMMAND!");
                }
                Console.WriteLine("________________________________"+"\n");
            }
            Console.ReadLine();
        }
    }
}
