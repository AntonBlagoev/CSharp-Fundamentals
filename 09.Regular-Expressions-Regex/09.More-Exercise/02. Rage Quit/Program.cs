﻿using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _02._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            string pattern = @"(([^\d]+)(\d+))";
            MatchCollection regex = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();

            foreach (var item in regex)
            {
                Match matches = Regex.Match(item.ToString(), pattern);
                string matchedString = matches.Groups[2].Value;
                int matchedDigit = int.Parse(matches.Groups[3].Value);
                
                for (int i = 0; i < matchedDigit; i++)
                {
                    sb.Append(matchedString);
                }
            }
            int count = sb.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.Write(sb);
        }
    }
}

/* Every gamer knows what rage-quitting means. It's basically when you're just not good enough and you blame everybody else for losing a game. 
 * You press the CAPS LOCK key on the keyboard and flood the chat with gibberish to show your frustration.
 * Chochko is a gamer and a bad one at that. He asks for your help – he wants to be the most annoying kid on his team, 
 * so when he rage-quits he wants something truly spectacular. He'll give you a series of strings followed by non-negative numbers, 
 * e.g. "a3"; you need to print on the console each string repeated N times; convert the letters to uppercase beforehand. 
 * In the example, you need to write back "AAA". 
 * On the output, print first a statistic of the number of unique symbols used 
 * (the casing of letters is irrelevant, meaning that 'a' and 'A' are the same); the format should be "Unique symbols used {0}". 
 * Then, print the rage message itself.
 * The strings and numbers will not be separated by anything. The input will always start with a string and for each string, 
 * there will be a corresponding number. The entire input will be given on a single line; Chochko is too lazy to make your job easier.
 * 
 * Input
 * •	The input data should be read from the console.
 * •	It consists of a single line holding a series of string-number sequences.
 * •	The input data will always be valid and in the format described. There is no need to check it explicitly.
 * 
 * Output
 * •	The output should be printed on the console. It should consist of exactly two lines.
 * •	On the first line, print the number of unique symbols used in the message.
 * •	On the second line, print the resulting rage message itself.
 * 
 * Constraints
 * •	The count of string-number pairs will be in the range [1…20000].
 * •	Each string will contain any character except digits. The length of each string will be in the range [1…20].
 * •	The repeat count for each string will be an integer in the range [0…20].
 * •	Allowed working time for your program: 0.3 seconds. Allowed memory: 64 MB.
 * 
 * INPUT
 * a3
 * 
 * OUTPUT
 * Unique symbols used: 1
 * AAA
 * 
 * COMMENT
 * We have just one string-number pair. The symbol is 'a', convert it to uppercase and repeat 3 times: AAA.
 * Only one symbol is used ('A').
 * 
 * INPUT
 * aSd2&5s@1
 * 
 * OUTPUT
 * Unique symbols used: 5
 * ASDASD&&&&&S@
 * 
 * COMMENT
 * "aSd" is converted to "ASD" and repeated twice; "&" is repeated 5 times; "s@" is converted to "S@" and repeated once.
 * 5 symbols are used: 'A', 'S', 'D', '&' and '@'.
 * 
 */
