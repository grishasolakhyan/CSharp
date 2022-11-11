using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ENTER ARRAY SIZE:");
                int l = Convert.ToInt32(Console.ReadLine());
                int[] A = new int[l];
                Random R = new Random();
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = R.Next(0, 50);
                    Console.WriteLine("A[" + i + "]:\t" + A[i]);
                }
                int sum = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    int m = A[i];
                    if (m % 9 == 0)
                    {
                        sum += m;
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine("THE SUM OF MULTIPLES OF 9 IS EQUAL " + sum);
                Console.WriteLine("\n");
                for (int i = 0; i < A.Length; i++)
                {
                    int n = A[i];
                    if (!(n % 7 == 0))
                    {
                        Console.WriteLine("ELEMENT OF THE ARRAY, THE NUMBER OF WHICH IS NOT DIVISIBLE BY 7:\t" + "A[" + i + "]");
                    }
                    else
                    {
                        Console.WriteLine("ELEMENT OF THE ARRAY, THE NUMBER OF WHICH IS DIVISIBLE BY 7:\t" + "A["+i+"]");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
