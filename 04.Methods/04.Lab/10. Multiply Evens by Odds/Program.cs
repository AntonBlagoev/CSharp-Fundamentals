using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            inputNumber = Math.Abs(inputNumber);

            int evenSum = GetSumOfEvenDigits(inputNumber);
            int oddSum = GetSumOfOddDigits(inputNumber);
            int sum = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(sum);
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
        static int GetSumOfEvenDigits(int inputNumber)
        {
            int evenSum = 0;
            int digits = inputNumber;

            while (digits > 0)
            {
                int currentDigit = digits % 10;
                if (currentDigit % 2 == 0)
                {
                    evenSum += currentDigit;
                }
                digits = digits / 10;
            }
            return evenSum;
        }
        static int GetSumOfOddDigits(int inputNumber)
        {
            int oddSum = 0;
            int digits = inputNumber;

            while (digits > 0)
            {
                int currentDigit = digits % 10;
                if (currentDigit % 2 != 0)
                {
                    oddSum += currentDigit;
                }
                digits = digits / 10;
            }
            return oddSum;
        }
    }
}

/* Create a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
 * •	Create a method called GetMultipleOfEvenAndOdds()
 * •	Create a method GetSumOfEvenDigits()
 * •	Create GetSumOfOddDigits()
 * •	You may need to use Math.Abs() for negative numbers
 * 
 * Input
 * -12345
 * Output
 * 54
 * Comment
 * Evens: 2 4
 * Odds: 1 3 5
 * Even sum: 6
 * Odd sum: 9
 * 6 * 9 = 54
 * 
 * Input
 * 3453466
 * Output
 * 220
 * 
 * 
 */