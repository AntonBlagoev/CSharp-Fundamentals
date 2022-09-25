using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inputString, @"([@|#])([a-zA-Za-z]{3,})\1{2}([a-zA-Za-z]{3,})");

            if (matches.Count != 0)
            {
                Console.WriteLine(($"{matches.Count} word pairs found!"));

                List<string> words = new List<string>();
                List<string> wordsMirror = new List<string>();

                foreach (Match item in matches)
                {
                    string firstWord = item.Groups[2].Value;
                    string secondWord = item.Groups[3].Value;
                    string secondWordReversed = new string(secondWord.ToCharArray().Reverse().ToArray()) ;

                    //char[] secondWordChars = item.Groups[3].Value.ToCharArray();
                    //Array.Reverse(secondWordChars);
                    //string secondWordReversed = string.Join("", secondWordChars);

                    if (firstWord == secondWordReversed)
                    {
                        words.Add(firstWord);
                        wordsMirror.Add(secondWord);
                    }
                }
                if (words.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    for (int i = 0; i < words.Count; i++)
                    {
                        if (i < words.Count - 1)
                        {
                            Console.Write($"{words[i]} <=> {wordsMirror[i]}, ");
                        }
                        else
                        {
                            Console.Write($"{words[i]} <=> {wordsMirror[i]}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
