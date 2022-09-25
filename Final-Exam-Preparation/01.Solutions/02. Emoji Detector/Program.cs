using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            MatchCollection emojis = Regex.Matches(inputString, @"([:]{2}|[*]{2})([A-Z][a-z]{2,})(\1)");
            MatchCollection coolDigits = Regex.Matches(inputString, @"\d");

            long coolThresholdSum = 1;

            foreach (Match digit in coolDigits)
            {
                coolThresholdSum *= int.Parse(digit.Value);
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojis)
            {
                string emojiCharArr = emoji.Groups[2].Value;
                long currEmojiThresholdSum = emojiCharArr.ToCharArray().Sum(x => x);

                //long currEmojiThresholdSum = 0;
                //char[] emojiChars = emoji.Groups[2].Value.ToCharArray();      \\v.1
                //foreach (var emojiChar in emojiChars)
                //{
                //    char currChar = char.Parse(emojiChar.ToString());
                //    currEmojiThresholdSum += currChar;
                //}

                //foreach (var emojiChar in emojiCharArr.ToCharArray())         \\v.2
                //{
                //    currEmojiThresholdSum += emojiChar;
                //}

                if (currEmojiThresholdSum >= coolThresholdSum)
                {
                    Console.WriteLine(emoji);
                }
            }
        }
    }
}
