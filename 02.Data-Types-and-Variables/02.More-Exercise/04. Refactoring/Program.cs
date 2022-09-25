using System;

namespace _04._Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 2; i <= inputNumber; i++)
            {
                string isPrimeNumber = "true";
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = "false";
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrimeNumber}");
            }

        }
    }
}
