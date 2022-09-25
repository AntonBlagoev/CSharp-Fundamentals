using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

/* Create a program to sum all of the adjacent equal numbers in a list of decimal numbers, starting from left to right.
 * •	After two numbers are summed, the result could be equal to some of its neighbors and should be summed as well (see the examples below)
 * •	Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available)
 * 
 * Examples
 * 
 * Input
 * 3 3 6 1
 * Output
 * 12 1
 * Explanation
 * 3 3 6 1  6 6 1  12 1
 * 
 * Input
 * 8 2 2 4 8 16
 * Output
 * 16 8 16
 * Explanation
 * 8 2 2 4 8 16  8 4 4 8 16  8 8 8 16  16 8 16
 * 
 * Input
 * 5 4 2 1 1 4
 * Output
 * 5 8 4
 * Explanation 
 * 5 4 2 1 1 4  5 4 2 2 4  5 4 4 4  5 8 4
 * 
 */