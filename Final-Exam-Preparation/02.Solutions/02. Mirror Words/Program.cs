using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inputText, @"([@#])([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1");

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            List<string> mirrorList = new List<string>();

            foreach (Match match in matches)
            {
                string firstWord = match.Groups[2].Value;
                string secondWord = match.Groups[3].Value;
               
                string secondWordReversed = string.Join("", secondWord.ToCharArray().Reverse().ToArray());
                //string secondWordReversed = new string(secondWord.ToCharArray().Reverse().ToArray());

                if (firstWord == secondWordReversed)
                {
                    mirrorList.Add(firstWord + " <=> " + secondWord);
                }
            }

            if (mirrorList.Count != 0)
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
