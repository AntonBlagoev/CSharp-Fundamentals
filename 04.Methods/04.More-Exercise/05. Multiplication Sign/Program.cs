using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int[] array = new int[] { num1, num2, num3 };
            
            bool isZero = false;
            bool isNegativ = false;
            int countNegativ = 0;

            foreach (int num in array)
            {
                if (num == 0)
                {
                    isZero = true;
                    break;
                }
                else if (num < 0)
                {
                    isNegativ = true;
                    countNegativ++;
                }
                
            }
            if (isZero)
            {
                Console.WriteLine("zero");
            }
            else if (isNegativ && countNegativ != 2)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }

        }
    }
}

/* You are given a number num1, num2 and num3. Write a program that finds if num1 * num2 * num3 (the product) is negative, positive or zero. 
 * Try to do this WITHOUT multiplying the 3 numbers.
 * 
 * Input
 * 2
 * 3
 * -1
 * 
 * Output
 * negative
 * 
 * Input
 * 2
 * 3
 * 1
 * 
 * Output
 * positive
 * 
 */