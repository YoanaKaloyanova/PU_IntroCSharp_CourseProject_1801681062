using System;

namespace Task3
{
    class Program
    {
        //Задача 48/б)
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи x:");
            double x = double.Parse(Console.ReadLine());
            double y = 0;
            if (x <= 0)
            {
                y = x + 2;
            }
            else if (x > 0 && x < 1)
            {
                y = x - 2;
            }
            else if (x >= 1)
            {
                y = 3 * x;
            }
            Console.WriteLine($"y={y}");
        }
    }
}
