using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] money = new int[20];
            int R = 0;
            for (int i=0; i<money.Length; i++)
            {
                money[i]= R+=5;
                Console.WriteLine("A[" + i + "]:" + money[i]+"$");
            }
            Console.WriteLine("ENTER RUR TO DOLLAR RATE: ");
            R = 0;
            int cur = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<money.Length; i++)
            {
                R+=5;
                int tmd = R * cur;
                money[i] = tmd;
                Console.WriteLine("A[" + i + "]:" + money[i] + "Rub");
            }
            Console.ReadLine();

        }
    }
}
