using System;
namespace Program6
{
class MinMax
{
    static void Main(string[] args)
    {
            Console.WriteLine("НЕ ОТСОРТИРОВАННЫЙ МАССИВ");
            int[] A = new int[10];
            Random R = new Random();
            for (int i=0; i<A.Length; i++)
            {
                A[i] = R.Next(0, 100);
                Console.WriteLine("A[" + i + "]:" + A[i]);
            }
            Console.WriteLine("ОТСОРТИРОВАНННЫЙ МАССИВ");
            for(int i=0; i<A.Length; i++)
            {
                for(int j=i+1; j<A.Length; j++)
                {
                    if(A[i]>A[j])
                    {
                        int P = A[i];
                        A[i] = A[j];
                        A[j] = P;
                    }
                }
                Console.WriteLine("A[" + i + "]:" + A[i]);
            }
            Console.ReadKey();
    }
}
}
