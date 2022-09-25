using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            MatchCollection coolTresholdMatches = Regex.Matches(inputString, @"\d");
            MatchCollection emojisMatches = Regex.Matches(inputString, @"([:]{2}|[*]{2})([A-Z][a-z]{2,})\1");

            long coolThresholdSum = 1;
            foreach (Match item in coolTresholdMatches)
            {
                coolThresholdSum *= int.Parse(item.Value);
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{emojisMatches.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojisMatches)
            {

                int currentEmojiThresholdSum = 0;
                currentEmojiThresholdSum = emoji.Groups[2].Value.ToString().ToCharArray().Sum(x => x);

                //char[] tmpEmojiCharArray = emoji.Groups[2].Value.ToString().ToCharArray();
                //for (int i = 0; i < tmpEmojiCharArray.Length; i++)
                //{
                //    currentEmojiThresholdSum += tmpEmojiCharArray[i];
                //}

                if (currentEmojiThresholdSum >= coolThresholdSum)
                {
                    Console.WriteLine(emoji);
                }
            }
        }
    }
}
