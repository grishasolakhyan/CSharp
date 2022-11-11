using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam10
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
                            A[i, j] = R.Next(-50, 50);
                            Console.Write("A[" + i + ";" + j + "]:" + A[i, j] + "\t");
                        }
                    }
                    int sum = 0;
                    for (int i = 0; i < A.GetLength(1); i++)
                    {
                        for (int j = 0; j < A.GetLength(1); j++)
                        {
                            if (i == j)
                            {
                                int r = A[i, j];
                                sum += r;
                            }
                        }
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("THE SUM OF THE NUMBERS OF THE MAIN DIAGONAL=" + sum);

                    int sum2 = 0;
                    int V = 0;
                    for (int i = 0; i < A.GetLength(1); i++)
                    {
                        for (int j = 0; j < A.GetLength(1); j++)
                        {
                            if (i < (A.GetLength(1) - 1 - j))
                            {
                                V++;
                                int k = A[i, j];
                                sum2 += k;
                            }
                        }
                    }
                    double arph = sum2 / V;
                    Console.WriteLine("ARITHMETIC AVERAGE OF NUMBERS OVER SIDE DIAGONAL=" + arph);
                }
                else Console.WriteLine("THE DIMENSION OF THE MATRIX IS INCORRECTLY ENTERED");
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}