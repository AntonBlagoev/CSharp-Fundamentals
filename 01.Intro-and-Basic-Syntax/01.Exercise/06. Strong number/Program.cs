using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int factorielEachNumber = 1;
            int sumAllFactoriels = 0;
            int inputNumber = number;

            while (inputNumber > 0)
            {
                int singleDigit = inputNumber % 10;

                for (int i = 1; i <= singleDigit; i++)
                {
                    factorielEachNumber *= i;
                }
                sumAllFactoriels += factorielEachNumber;
                factorielEachNumber = 1;
                inputNumber /= 10;
            }

            if (number == sumAllFactoriels)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
