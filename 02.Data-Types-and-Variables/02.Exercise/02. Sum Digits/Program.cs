using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int inputNumberSum = 0;

            while (inputNumber != 0)
            {
                inputNumberSum += inputNumber % 10;
                inputNumber = inputNumber / 10;
            }

            Console.WriteLine(inputNumberSum);

        }
    }
}
