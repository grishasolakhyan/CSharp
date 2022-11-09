using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num="";
            while (true)
            {
                Console.Write("ENTER FOUR-DIGITAL NUMBER: ");
                num = Console.ReadLine();
                if (num.Length == 4)
                {
                    int A = Convert.ToInt32(num[0].ToString()) +
                        Convert.ToInt32(num[1].ToString()) +
                        Convert.ToInt32(num[2].ToString()) +
                        Convert.ToInt32(num[3].ToString());

                    if (A % 4 == 0)
                    {
                        Console.WriteLine("The number is divisible by 4");
                    }
                    else
                    {
                        Console.WriteLine("The number is NOT divisible by 4");
                    }
                }
                else Console.Write("ENTER A STRICTLY FOUR-DIGITAL NUMBER\n\n");
            }
            Console.ReadLine();
        }
    }
}
