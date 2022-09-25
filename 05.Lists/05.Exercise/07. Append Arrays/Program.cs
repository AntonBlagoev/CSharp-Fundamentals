using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split("|").Reverse().ToList();

            List<string> appendedList = new List<string>();

            foreach (var item in inputList)
            {
                appendedList.AddRange((item.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList()));
            }
            Console.WriteLine(string.Join(" ", appendedList));
            
        }
    }
}

/* Create a program to append several arrays of numbers one after another.
 * •	Arrays are separated by '|'
 * •	Their values are separated by spaces (' ', one or several)
 * •	Take all arrays starting from the rightmost and going to the left and place them in a new array in that order
 * 
 * Examples
 * 
 * Input
 * 1 2 3 |4 5 6 |7  8
 * 
 * Output
 * 7 8 4 5 6 1 2 3
 * 
 * Input
 * 7 | 4  5|1 0| 2 5 |3
 * 
 * Output
 * 3 2 5 1 0 4 5 7
 * 
 * Input
 * 1| 4 5 6 7  |  8 9
 * 
 * Output
 * 8 9 4 5 6 7 1
 * 
 * 
 */