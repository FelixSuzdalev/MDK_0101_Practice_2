using System;

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine()), y = 0;

            if (x <= 3) y = x * x + 3 * x + 9;
            if (x > 3) y = Math.Sin(x) / (x * x - 9);
            Console.WriteLine("Для x = {0:f2} ", x);
            Console.WriteLine("Результат = {0:f2}", y);
        }
    }
}