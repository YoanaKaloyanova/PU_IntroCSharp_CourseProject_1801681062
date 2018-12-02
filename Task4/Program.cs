using System;

namespace Task4
{
    class Program
    {
        //Задача 209/е)
        static Random Random = new Random();
        static void Main(string[] args)
        {
            int[] intArray = new int[100];
            Console.WriteLine("Тук имаме 100 случайно генерирани числа в интервала от 0 до 132.");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Random.Next(132);
                Console.WriteLine(intArray[i]);

            }
            for (int i = 0; i < intArray.Length; i++)
            {
                if ((intArray[i] > 26) && (intArray[i] <= 100))
                    Console.WriteLine($"{intArray[i]} е между 26 и 100.");
            }
        }
    }
}
