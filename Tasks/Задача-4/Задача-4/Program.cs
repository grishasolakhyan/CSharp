using System;

namespace Задача_4
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
                                "\n3)ЧТО ТАКОЕ ЦИКЛ FOR?" +
                                "\n4)ЧТО ТАКОЕ ЦИКЛ WHILE?" +
                                "\n5)ЧТО ТАКОЕ ЦИКЛ DO WHILE?" +
                                "\nВведите номер задачи: "
                             );
                num = (char)Console.Read();
                switch (num)
                {
                    case '1':
                        Console.WriteLine("\nОператор условия if-else служит для выбора\nнаправления работы программы в зависимости от\nусловий, сложившихся в данной точке программы на\nмомент ее выполнения.");
                        break;
                    case '2':
                        Console.WriteLine("\nКонструкция switch-case — это удобная замена\nдлинной if-else конструкции, которая сравнивает\nпеременную с несколькими константными\nзначениями, например int или char.");
                        break;
                    case '3':
                        Console.WriteLine("\nЦикл FOR -  это управляющая конструкция программного кода, которая нарушает линейность исполнения алгоритма и позволяет выполнить указанный код множество раз.");
                        break;
                    case '4':
                        Console.WriteLine("\nЦикл WHILE - цикл, который выполняется, пока истинно некоторое условие, указанное перед его началом.");
                        break;
                    case '5':
                        Console.WriteLine("\nЦикл DO WHILE - цикл, в котором условие проверяется после выполнения тела цикла.");
                        break;
                    default:
                        Console.WriteLine("\nНеверно выбран номер задачи!");
                        break;
                }
                Console.WriteLine("\n");
                Console.ReadLine();
            }
        }
    }
}