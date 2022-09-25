using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                int currentNumber = i;
                int sumOfDigits = 0;
                int oddCount = 0;

                while (currentNumber > 0)
                {
                    int currentDigitOfNumber = currentNumber % 10;
                    sumOfDigits += currentDigitOfNumber;

                    if (currentDigitOfNumber % 2 != 0)
                    {
                        oddCount++;
                    }

                    if (currentNumber >= 10)
                    {
                        currentNumber = currentNumber / 10;
                    }
                    else
                    {
                        currentNumber = 0;
                    }
                }

                if (sumOfDigits % 8 == 0)
                {
                    if (oddCount > 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}


/* A top number is an integer that holds the following properties:
 * •	Its sum of digits is divisible by 8, e.g. 8, 17, 88
 * •	Holds at least one odd digit, e.g. 232, 707, 87578
 * •	Some examples of top numbers are: 17, 161, 251, 4310, 123200 
 * Create a program to print all top numbers in the range [1…n].
 * You will receive a single integer from the console, representing the end value.
 * 
 * Input
 * 50
 * Output
 * 17
 * 35
 * 
 * Input
 * 100
 * Output
 * 17
 * 35
 * 53
 * 71
 * 79
 * 97
 * 
 */