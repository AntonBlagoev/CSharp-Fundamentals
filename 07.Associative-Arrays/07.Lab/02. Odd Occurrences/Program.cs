using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsInput = Console.ReadLine().Split();
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in wordsInput)
            {
                string wordToLower = word.ToLower();

                if (!words.ContainsKey(wordToLower))
                {
                    words.Add(wordToLower, 0);
                }

                words[wordToLower]++;
            }

            //foreach (var word in words)
            //{
            //    if (word.Value % 2 != 0)
            //    {
            //        Console.Write($"{word.Key} ");
            //    }
            //}

            string[] oddWordsCount = words
                .Where(w => w.Value % 2 != 0)
                .Select(w => w.Key)
                .ToArray();

            Console.WriteLine(string.Join(" ", oddWordsCount));


        }
    }
}
/* 2.	Odd Occurrences
 * 
 * Create a program that extracts all elements from a given sequence of words that are present in it an odd number of times (case-insensitive).
 * •	Words are given on a single line, space-separated.
 * •	Print the result elements in lowercase, in their order of appearance.
 * 
 * Input
 * Java C# PHP PHP JAVA C java
 * Output
 * java c# c
 * 
 * Input
 * 3 5 5 hi pi HO Hi 5 ho 3 hi pi
 * Output
 * 5 hi
 * 
 * Input
 * a a A SQL xx a xx a A a XX c
 * Output
 * a sql xx c
 * 
 */