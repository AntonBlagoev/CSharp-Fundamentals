using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inputText, @"([@]|[#])([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1");
            List<string> mirrorList = new List<string>();

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            foreach (Match item in matches)
            {
                string wordOne = item.Groups[2].Value;
                string wordTwo = item.Groups[3].Value;
                string wordtwoMirror = new string(wordTwo.ToCharArray().Reverse().ToArray());
                if (wordOne == wordtwoMirror)
                {
                    mirrorList.Add(wordOne + " <=> " + wordTwo);
                }
            }

            if (mirrorList.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorList));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }

        }
    }
}
