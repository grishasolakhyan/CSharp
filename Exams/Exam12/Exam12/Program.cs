using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam12
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n, m;

                Console.WriteLine("Enter number of lines: ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number of columns: ");
                m = Convert.ToInt32(Console.ReadLine());

                if (n > 1 && m > 1)
                {
                    int[,] A = new int[n, m];
                    Random rand = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            A[i, j] = rand.Next(-50, 50);
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write(A[i, j].ToString() + "\t");
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");


                    int max = -100;//search for the largest among negative ones
                    int imax = 0, jmax = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            if (A[i, j] < 0 && A[i, j] > max)
                            {
                                max = A[i, j];
                                imax = i;
                                jmax = j;
                            }
                        }
                    }

                    A[imax, jmax] *= -1;//replacement with the opposite value

                    int min = 100; //search for the smallest among the positive
                    int imin = 0, jmin = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            if (A[i, j] > 0 && A[i, j] < min)
                            {
                                min = A[i, j];
                                imin = i;
                                jmin = j;
                            }
                        }
                    }

                    A[imin, jmin] = 0; //zero replacement

                    Console.WriteLine("Modified Array");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write(A[i, j].ToString() + "\t");
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");
                }
                else Console.WriteLine("THE DIMENSION OF THE MATRIX IS INCORRECTLY ENTERED\n");
            }
            Console.ReadLine();
        }
    }
}
