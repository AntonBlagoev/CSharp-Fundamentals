using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            
            bool isSpecialNum = false;
            for (int i = 1; i <= inputNumber; i++)
            {
                int sumOfDiggits = 0; 
                int currentDiggit = i;
                while (i > 0)
                {
                    sumOfDiggits += i % 10;
                    i = i / 10;
                }
                isSpecialNum = (sumOfDiggits == 5) || (sumOfDiggits == 7) || (sumOfDiggits == 11);
                Console.WriteLine("{0} -> {1}", currentDiggit, isSpecialNum);
                sumOfDiggits = 0;
                i = currentDiggit;
            }

        }
    }
}
