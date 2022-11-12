using System;

        class Help 
        {
        public char num;
        public bool W = true;
        public void showmenu()
            {
            Console.WriteLine("ВЫБЕРЕТЕ ЗАДАЧУ:" +
                          "\n1)ЧТО ТАКОЕ ОПЕРАТОР IF-ELSE?" +
                          "\n2)ЧТО ТАКОЕ ОПЕРАТОР SWITCH?" +
                          "\n3)ЧТО ТАКОЕ ЦИКЛ FOR?" +
                          "\n4)ЧТО ТАКОЕ ЦИКЛ WHILE?" +
                          "\n5)ЧТО ТАКОЕ ЦИКЛ DO WHILE?" +
                          "\nq)ЗАКРЫТИЕ ЗАДАЧИ");
            }
            public void helpon()
            {
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
                case 'q':
                    W = false;
                    break;
            }
        }
            public bool isvalid()
            {
            Console.WriteLine("\nВВЕДИТЕ НОМЕР СПРАВОЧНИКА");
            num = (char)Console.Read();
            if (num == '1' | num == '2' | num == '3' | num == '4' | num == '5' | num == 'q')
            { return true; } else { return false; } 
            }
        }
namespace Задача_5
{
    class Program5
    {
        static void Main(string[] args)
        {
            Help button = new Help();
            button.showmenu();
            do
            {
                if (button.isvalid() == true)
                {
                    button.helpon();
                }
                else
                {
                    Console.WriteLine("\n\nДАННОГО СПРАВОЧНИКА НЕТ");
                    Console.ReadLine();
                }
            }
            while (button.W);
            Console.ReadLine();
        }
    }
    }