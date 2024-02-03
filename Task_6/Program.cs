using System;

namespace Task_6
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("\nВведите номер времени года:\n(1 - зима, 2 - весна, 3 - лето, 4 - осень)");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1: Console.WriteLine(" Зима:\n  Декабрь - 31 день\n  Январь - 31 день\n  Февраль - 28 (29 в високосный год) дней"); break;
                    case 2: Console.WriteLine(" Весна:\n  Март - 31 день\n  Апрель - 30 дней\n  Май - 31 день"); break;
                    case 3: Console.WriteLine(" Лето:\n  Июнь - 30 дней\n  Июль - 31 день\n  Август - 31 день"); break;
                    case 4: Console.WriteLine(" Осень:\n  Сентябрь - 30 дней\n  Октябрь - 31 день\n  Ноябрь - 30 дней"); break;
                    default: Console.WriteLine("Больше времен года нет"); break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Ошибка!Вы ничего не ввели :)");
            }
            Console.Write("\nНажмите Enter для продолжения работы программы");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.ReadKey();
                Main();
            };
        }
    }
}