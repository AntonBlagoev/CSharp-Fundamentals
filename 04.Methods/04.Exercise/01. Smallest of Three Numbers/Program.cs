using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(num1, num2, num3));

        }

        static int SmallestNumber(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

        static int SmallestNumberShort(int a, int b, int c) => Math.Min(a, Math.Min(b, c)); // short version
    }
}

/* Create a method that prints out the smallest of three integer numbers.
 * 
 * Input
 * 2
 * 5
 * 3
 * 
 * Output
 * 2
 * 
 * 
 * Input
 * 600
 * 342
 * 123
 * 
 * Output
 * 123
 * 
 * Input
 * 25
 * 21
 * 4
 * 
 * Output
 * 4
 * 
 */