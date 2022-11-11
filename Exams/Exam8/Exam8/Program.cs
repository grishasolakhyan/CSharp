using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8
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
                    A[i] = R.Next(-50, 50);
                    Console.WriteLine("A[" + i + "]:" + A[i]);
                }
                int sum = 0;
                int c = 0;
                double Arph = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] < 0)
                    {
                        c++;
                        int r = A[i];
                        sum += r;
                    }
                }
                Arph = sum / c;
                Console.WriteLine("ARITHMETIC AVERAGE OF NEGATIVE NUMBERS IS EQUAL " + Arph);
                int sum_nech = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    int ch = A[i];
                    if (!(ch % 2 == 0))
                    {
                        sum_nech += ch;
                    }
                }
                Console.WriteLine("THE SUM OF ODD NUMBERS IS EQUAL TO " + sum_nech);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
    
}
