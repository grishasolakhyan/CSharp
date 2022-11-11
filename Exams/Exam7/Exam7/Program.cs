using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER ARRAY SIZE:");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int[] A = new int[l];
            Random R = new Random();
            for(int i=0; i<A.Length; i++)
            {
                A[i] = R.Next(0, 100);
                Console.WriteLine("A[" + i + "]:" + A[i]);
            }
            Console.WriteLine("\nENTER THE NUMBER: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            { 
             Console.WriteLine("SORTED ARRAY");
                for (int i = 0; i < A.Length; i++)
                {
                    if ((A[i] < num))
                    {
                        A[i] = num;
                    }
                    Console.WriteLine("A[" + i + "]:" + A[i]);
                }
            }
            else Console.WriteLine("THERE ARE NO NUMBERS STRICTLY LESS THAN ZERO IN THE ARRAY");
            Console.ReadLine();
        }
    }
}
