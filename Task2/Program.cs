using System;

namespace Task2
{
    class Program
    {
        //Тест 1 - Задача 7/2-ра група
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи данни за цилиндър:");
            Console.WriteLine("Въведи H:");
            double H = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведи R:");
            double R = double.Parse(Console.ReadLine());
            const double pi = Math.PI;
            double s = 2 * pi * R * H;
            double S = 2 * pi * R * H + 2 * pi * R * R;
            Console.WriteLine($"Околната повърхнина на цилиндъра е {s}");
            Console.WriteLine($"Пълната повърхнина на цилиндъра е {S}");
        }
    }
}
