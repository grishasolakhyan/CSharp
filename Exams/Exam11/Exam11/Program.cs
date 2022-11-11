using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
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
                    int[,] array = new int[n, m];
                    Random rand = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            array[i, j] = rand.Next(-50, 50);
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write(array[i, j].ToString() + ", ");
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");

                    for (int i = 0; i < n; i++)
                    {
                        int max = array[i, 0];
                        int max_ind = 0;
                        for (int j = 0; j < m; j++)
                        {
                            if (max < array[i, j])
                            {
                                max = array[i, j];
                                max_ind = j;
                            }
                        }
                        array[i, max_ind] = 0; //replacing the maximum with 0
                    }

                    for (int i = 0; i < n; i++)
                    {
                        int min = array[i, 0];
                        int min_ind = 0;
                        for (int j = 0; j < m; j++)
                        {
                            if (min > array[i, j])
                            {
                                min = array[i, j];
                                min_ind = j;
                            }
                        }
                        array[i, min_ind] *= -1; //replacement of the minimum by the opposite
                    }

                    Console.WriteLine("Modified array");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write(array[i, j].ToString() + ", ");
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