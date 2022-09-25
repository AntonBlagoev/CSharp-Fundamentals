using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            inputList.RemoveAll(num => num < 0);
            inputList.Reverse();

            if (inputList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", inputList));
            }
        }
    }
}

/* Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. 
 * If there are no elements left in the list, print "empty".
 *  
 * Input
 * 10 -5 7 9 -33 50
 * Output
 * 50 9 7 10
 * 
 * Input
 * 7 -2 -10 1
 * Output
 * 1 7
 * 
 * Input
 * -1 -2 -3
 * Output
 * empty
 * 
 */
