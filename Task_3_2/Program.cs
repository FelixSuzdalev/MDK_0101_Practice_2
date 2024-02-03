using System;

namespace Task_3_2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите два любых значения для переменных x и y:");
            double x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine());
            if (x >= y) Console.WriteLine("Значение x = {0:f2} и y = {1:f2}", x, y);
            else
            {
                double z;
                z = x; x = y; y = z;
                Console.WriteLine("Значение x = {0:f2} и y = {1:f2}", x, y);
            }
        }
    }
}
