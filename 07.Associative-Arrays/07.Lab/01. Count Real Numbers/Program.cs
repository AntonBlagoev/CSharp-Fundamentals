using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts.Add(number, 0);
                }

                counts[number]++;

            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
/* 1.	Count Real Numbers
 * 
 * Read a list of integers and print them in ascending order, along with their number of occurrences.
 * 
 * Input
 * 8 2 2 8 2
 * Output
 * 2 -> 3
 * 8 -> 2
 * 
 * Input
 * 1 5 1 3
 * Output
 * 1 -> 2
 * 3 -> 1
 * 5 -> 1
 * 
 * Input
 * -2 0 0 2
 * Output
 * -2 -> 1
 * 0 -> 2
 * 2 -> 1
 * 
 */