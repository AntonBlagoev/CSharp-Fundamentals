using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] inputChars = Console.ReadLine().ToCharArray();

            Dictionary<char, int> charDict = new Dictionary<char, int>();

            foreach (var item in inputChars)
            {
                if (item != ' ')
                {
                    if (!charDict.ContainsKey(item))
                    {
                        charDict[item] = 0; // charDict.Add(item, 0)
                    }
                    charDict[item]++;
                }
            }


            foreach (var item in charDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
/* 1.	Count Chars in a String
 * 
 * Create a program that counts all characters in a string, except for space (' '). 
 * Print all the occurrences in the following format:
 * "{char} -> {occurrences}"
 * 
 * Input
 * text
 * 
 * Output
 * t -> 2
 * e -> 1
 * x -> 1
 * 
 * Input
 * text text text
 * 
 * Output
 * t -> 6
 * e -> 3
 * x -> 3
 * 
 */