using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_
{
    class Program
    {

        class Figure
        {
            public int i;
            public double a, b; //прямоугольник
            public double r; //круг
            public double a1, b1, c1; //треугольник
            bool exist = true;

            public void Show()
            {


                if (i == 1)
                {
                    Console.WriteLine("Your shape is a RECTANGLE with sides " + a + " and " + b);
                }
                else if (i == 2)
                {
                    Console.WriteLine("Yor shape is CIRCLE with radius " + r);
                }
                else if (i == 3)
                {
                    if (a1 > 0 & b1 > 0 & c1 > 0 & (a1 + b1) > c1 & (a1 + c1) > b1 & (b1 + c1) > a1)
                    {
                        Console.WriteLine("Your shape is a TRIANGLE with sides " + a1 + " and " + b1 + " and " + c1);
                    }
                    else
                    {
                        Console.WriteLine("THIS TRIANGLE DOES NOT EXIST!");
                        exist = false;
                    }
                }
            }

            public void P()
            {
                if (i == 1)
                {
                    Console.WriteLine("Perimetr: " + (a + a + b + b));
                }
                else if (i == 2)
                {
                    Console.WriteLine("Length of circle: " + 2 * Math.PI * r);
                }
                else if (i == 3)
                {
                    if (exist == true)
                    {
                        Console.WriteLine("Perimetr: " + (a1 + b1 + c1));
                    }
                }
            }

            public void S()
            {
                if (i == 1)
                {
                    Console.WriteLine("Area: " + a * b);
                }
                else if (i == 2)
                {
                    Console.WriteLine("Area: " + Math.PI * r);
                }
                else if (i == 3)
                {
                    if (exist == true)
                    {
                        double p = (a1 + b1 + c1) / 2;
                        Console.WriteLine("Area: " + Math.Sqrt(p * (p - a1) * (p - b1) * (p - c1)));
                    }
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------

        class Rectangle : Figure
        {

        }

        class Circle : Figure
        {

        }

        class Triangle : Figure
        {

        }

        //-----------------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            Figure choice = new Figure();
            bool close = false;
            string i;
            do
            {
                Console.WriteLine("1 - Rectangle\n2 - Circle\n3 - Triangle\nq - Exit");
                Console.Write("\nCOMAND: ");
                i = Console.ReadLine();

                if (i == "1")
                {
                    Console.Write("a= ");
                    string q = Console.ReadLine();
                    double a = double.Parse(q);
                    Console.Write("b= ");
                    q = Console.ReadLine();
                    double b = double.Parse(q);

                    Rectangle x = new Rectangle();
                    x.i = 1;
                    x.a = a;
                    x.b = b;

                    x.Show();
                    x.P();
                    x.S();
                    break;
                }
                else if (i == "2")
                {
                    Console.Write("Radius= ");
                    string q1 = Console.ReadLine();
                    double a1 = double.Parse(q1);

                    Circle x1 = new Circle();
                    x1.i = 2;
                    x1.r = a1;

                    x1.Show();
                    x1.P();
                    x1.S();
                    break;
                }
                else if (i == "3")
                {
                    Console.Write("Enter sides of triangle: \na= ");
                    string q2 = Console.ReadLine();
                    double a2 = double.Parse(q2);
                    Console.Write("b= ");
                    q2 = Console.ReadLine();
                    double b2 = double.Parse(q2);
                    Console.Write("c= ");
                    q2 = Console.ReadLine();
                    double c2 = double.Parse(q2);

                    Triangle x2 = new Triangle();
                    x2.i = 3;
                    x2.a1 = a2;
                    x2.b1 = b2;
                    x2.c1 = c2;

                    x2.Show();
                    x2.P();
                    x2.S();
                    break;
                }
                else if (i == "q")
                {
                    close = true;
                    break;
                }
                else
                {
                    Console.Write("\nWRONG COMMAND");
                }
                Console.Write("\n\n");
            }
            while (close == false);
            Console.ReadLine();
        }
    }
}
