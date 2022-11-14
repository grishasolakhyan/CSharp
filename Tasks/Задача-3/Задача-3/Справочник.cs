using System;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num;
                Console.Write("1)ЧТО ТАКОЕ ОПЕРАТОР IF-ELSE?" +
                                    "\n2)ЧТО ТАКОЕ ОПЕРАТОР SWITCH?" +
                                    "\nВведите номер задачи: ");
                num = (char)Console.Read();
                switch (num)
                {
                    case '1':
                        Console.WriteLine("\nОператор условия if-else служит для выбора\nнаправления работы программы в зависимости от\nусловий, сложившихся в данной точке программы на\nмомент ее выполнения.");
                        break;
                    case '2':
                        Console.WriteLine("\nКонструкция switch-case — это удобная замена\nдлинной if-else конструкции, которая сравнивает\nпеременную с несколькими константными\nзначениями, например int или char.");
                        break;
                    default:
                        Console.WriteLine("\nНеверно выбран номер задачи");
                        break;
                }
                Console.WriteLine("\n");
                Console.ReadLine();
            }
        }
    }
}