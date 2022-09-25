using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            

            for (int num = 1; num <= inputNumber; num++)
            {
                int sumOfDigits = 0;
                int currentDigits = num;

                while (currentDigits > 0)
                {
                    sumOfDigits += currentDigits % 10;
                    currentDigits = currentDigits / 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{num} -> True");
                }
                else
                {
                    Console.WriteLine($"{num} -> False");

                }

            }





        }
    }
}
