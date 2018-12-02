using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 359
            Console.WriteLine("Въведете текст");
            string input = Console.ReadLine();
            Console.WriteLine("Въведете подниз А");
            string A = Console.ReadLine();
            Console.WriteLine("Въведете подниз B");
            string B = Console.ReadLine();
            Console.WriteLine("Въведете подниз X");
            string X = Console.ReadLine();


            FindX(input, A, B, X);
        }

        static void FindX(string input, string A, string B, string X)
        {
            if (input.Contains(A) && input.Contains(B))
            {
                int startIndex = input.IndexOf(A) + A.Length;
                int endIndex = input.IndexOf(B);
                string newString = "";
                for (int i = startIndex; i < endIndex - 1; i++)
                {
                    newString += input[i];
                }
                if (newString.Contains(X))
                {
                    Console.WriteLine($"Въведеният текст съдържа подниз {X}");
                }
                else Console.WriteLine($"Въведеният текст не съдържа подниз {X}");

            }
        }
    }
}
