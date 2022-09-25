using System;
using System.Linq;

namespace _04._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(word => word.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
/* 4.	Word Filter
 * 
 * Read an array of strings and take only words, whose length is an even number. Print each word on a new line.
 * 
 * Input
 * kiwi orange banana apple
 * Output
 * kiwi
 * orange
 * banana
 * 
 * Input
 * pizza cake pasta chips
 * Output
 * cake
 * 
 * 
 */