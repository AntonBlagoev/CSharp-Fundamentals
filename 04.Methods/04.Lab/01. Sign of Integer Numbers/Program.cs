using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CheckNumber(number);
        }

        static void CheckNumber(int number)
	{
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }

    }

    }
}

/* A single integer is given, create a method that checks if the given number is positive, negative, or zero. As a result print:
 * •	For positive number: "The number {number} is positive. "
 * •	For negative number: "The number {number} is negative. "
 * •	For zero number: "The number {number} is zero. "
 * 
 * Input
 *  2
 * Output
 * The number 2 is positive.
 * 
 * Input
 * -9
 * Output
 * The number -9 is negative.
 * 
 * 
 */