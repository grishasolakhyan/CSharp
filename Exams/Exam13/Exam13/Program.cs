using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam13
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ENTER DIE SIZE:");
                int l = Convert.ToInt32(Console.ReadLine());
                if (l > 1)
                {
                    int[,] A = new int[l, l];
                    Random R = new Random();
                    for (int i = 0; i < A.GetLength(1); i++)
                    {
                        for (int j = 0; j < A.GetLength(1); j++)
                        {
                            A[i, j] = R.Next(-10, 10);
                            Console.Write("A[" + i + ";" + j + "]:" + A[i, j] + "\t");
                        }
                        Console.WriteLine("\t");
                    }
                    Console.WriteLine("\n");
                    int[] B = new int[l];
                    Random X = new Random();
                    for (int j = 0; j < B.GetLength(0); j++)
                    {
                        B[j] = X.Next(-10, 10);
                        Console.Write("B[" + j + "]:" + B[j] + "\n");
                    }
                    Console.Write("\n");
                    int T;
                    int sum = 0;
                    Console.WriteLine("MATRIX MULTIPLY");
                    for (int i = 0; i < A.GetLength(1); i++)
                    {
                        for (int j = 0; j < A.GetLength(1); j++)
                        {
                            T = A[i, j] * B[j];
                            sum += T;
                        }
                        Console.Write(sum + "\n");
                    }
                }
                else Console.WriteLine("DIMENSIONS ENTERED INCORRECTLY\n");
            }
        }
    }
}
