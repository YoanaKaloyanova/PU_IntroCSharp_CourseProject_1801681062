using System;

namespace Task6
{
    class Program
    {
        //Задача 414
        static int SUM(int[] D)
        {
            int sum = 0;
            for (int i = 0; i < D.Length; i++)
            {
                if (D[i] % 2 == 1 && (D[i] > 0 && D[i] <= 100))
                {
                    sum += D[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи брой елементи на масив:");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];
            int max = 0;


            InputArray(A);
            Console.WriteLine($"Сумата на нечетните елементи в интервала (0,100] e :{SUM(A)}");
            InputArray(B);
            Console.WriteLine($"Сумата на нечетните елементи в интервала (0,100] e :{SUM(B)}");
            InputArray(C);
            Console.WriteLine($"Сумата на нечетните елементи в интервала (0,100] e :{SUM(C)}");
            Console.WriteLine("-------------------------------------------------------------");
            if (SUM(A) > SUM(B))
            {
                max = SUM(A);
            }
            else
            {
                max = SUM(B);
            }
            if (max < SUM(C))
            {
                max = SUM(C);
            }
            Console.WriteLine(max);
            Console.WriteLine("-------------------------------------------------------------");
            CalculateCElemts(A, B, C);

        }

        static void CalculateCElemts(int[] a, int[] b, int[] c)
        {
            int[] test = new int[a.Length];
            int counter = 1;
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = (int)(Math.Pow(a[i], (2 * counter - 1)) * Math.Pow(b[i], (2 * counter)));

                counter++;
                Console.WriteLine(test[i]);


            }
        }

        static void InputArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}]= ");
                a[i] = int.Parse(Console.ReadLine());

            }
        }
    }
}
