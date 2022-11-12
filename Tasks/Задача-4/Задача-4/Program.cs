using System;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Введите номер задачи:" +
                              "\n1)ЧТО ТАКОЕ ОПЕРАТОР IF-ELSE?" +
                              "\n2)ЧТО ТАКОЕ ОПЕРАТОР SWITCH?" +
                              "\n3)ЧТО ТАКОЕ ЦИКЛ FOR?" +
                              "\n4)ЧТО ТАКОЕ ЦИКЛ WHILE?" +
                              "\n5)ЧТО ТАКОЕ ЦИКЛ DO WHILE?");
            do
            {
                num = (char)Console.Read();
                Console.WriteLine("НЕВЕРНО ВЫБРАН НОМЕР ЗАДАЧИ");
            }
            while (num < '1' || num > '5');
            Console.ReadLine();
            switch (num)
                {
                    case '1':
                        Console.WriteLine("Оператор условия if-else служит для выбора\nнаправления работы программы в зависимости от\nусловий, сложившихся в данной точке программы на\nмомент ее выполнения.");
                        Console.ReadLine();
                        break;
                    case '2':
                        Console.WriteLine("Конструкция switch-case — это удобная замена\nдлинной if-else конструкции, которая сравнивает\nпеременную с несколькими константными\nзначениями, например int или char.");
                        Console.ReadLine();
                        break;
                    case '3':
                        Console.WriteLine("Цикл FOR - ");
                        Console.ReadLine();
                        break;
                    case '4':
                        Console.WriteLine("Цикл WHILE - ");
                        Console.ReadLine();
                        break;
                    case '5':
                        Console.WriteLine("Цикл DO WHILE - ");
                        Console.ReadLine();
                        break;
            }
        }
    }
}