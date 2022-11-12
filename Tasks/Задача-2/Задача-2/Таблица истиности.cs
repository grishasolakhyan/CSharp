using System;

namespace Таблица_истиности
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true, B = false;
            Console.WriteLine("A\tB\tAND\tOR\tXOR\tNOT");
            Console.WriteLine(B + "\t" + B + "\t" + (B & B) + "\t" + (B | B) + "\t" + (B ^ B) + "\t" + (!B));
            Console.WriteLine(B + "\t" + A + "\t" + (B & A) + "\t" + (B | A) + "\t" + (B ^ A) + "\t" + (!A));
            Console.WriteLine(A + "\t" + B + "\t" + (A & B) + "\t" + (A | B) + "\t" + (A ^ B) + "\t" + (!A));
            Console.WriteLine(A + "\t" + A + "\t" + (A & A) + "\t" + (A | A) + "\t" + (A ^ A) + "\t" + (!A));
            Console.ReadLine();
        }
    }
}
