using System;

namespace Task5
{
    class Program
    {
        //Задача 380
        static int Sss(int k)
        {
            Random rnd = new Random();
            int product = 1;
            for (int i = 1; i <= k; i++)
            {
                int currentNum = rnd.Next(-1000, 1000);
                if ((currentNum >= 10 && currentNum < 100) && currentNum % 10 == 5)
                {
                    product *= currentNum;
                }
            }
            return product;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи произволен брой елементи k:");
            int k = int.Parse(Console.ReadLine());
            int number;
            int sum = 0;
            do
            {
                Console.WriteLine("Въведи елемент:");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 1 || number % 2 == -1)
                {
                    sum += number;
                }
            }
            while (number != 0);
            Console.WriteLine($"Сумата на нечетните въведени числа е:{ sum}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Въведи 8 положителни числа:");
            double product = 1;
            double sqrteight;
            int[] arr = new int[8];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Въведи елемент:");
                arr[i] = int.Parse(Console.ReadLine());
                while (arr[i] < 0)
                {
                    Console.WriteLine("Въведи нов елемент:");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                product *= arr[i];
            }
            Console.WriteLine(product);
            sqrteight = Math.Pow(product, (1.0 / 8.0));
            Console.WriteLine(sqrteight);
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Въведете цяло произволно число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Въведете цяло произволно число b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Въведете цяло произволно число c: ");
            int c = int.Parse(Console.ReadLine());
            double result = Sss(Math.Abs(a - b)) * Sss(b + c);
            Console.WriteLine($"Резултат: {result}");
        }
    }
}
