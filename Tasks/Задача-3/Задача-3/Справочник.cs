using System;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Введите номер задачи:" +
                              "\n1)ЧТО ТАКОЕ ОПЕРАТОР IF-ELSE?" +
                              "\n2)ЧТО ТАКОЕ ОПЕРАТОР SWITCH?" +
                              "\n0)ЗАКРЫТЬ ЗАДАЧУ");
                num = (char)Console.Read();
                switch (num)
                {
                    case '1':
                        Console.WriteLine("Оператор условия if-else служит для выбора\nнаправления работы программы в зависимости от\nусловий, сложившихся в данной точке программы на\nмомент ее выполнения.");
                        break;
                    case '2':
                        Console.WriteLine("Конструкция switch-case — это удобная замена\nдлинной if-else конструкции, которая сравнивает\nпеременную с несколькими константными\nзначениями, например int или char.");
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("Неверно выбран номер задачи");
                        break;
                }
                Console.ReadKey();
        }
    }
}