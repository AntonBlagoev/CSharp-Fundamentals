using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            MatchCollection emojiMatches = Regex.Matches(inputText, @"([:]{2}|[*]{2})([A-Z][a-z]{2,})\1");
            MatchCollection coolThresholdMatches = Regex.Matches(inputText, @"\d");

            long coolThresholdSum = 1;
            foreach (Match number in coolThresholdMatches)
            {
                coolThresholdSum *= int.Parse(number.Value);
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojiMatches)
            {
                long currEmojiThresholdSum = emoji.Groups[2].Value.ToCharArray().Sum(x => x);

                //char[] currEmojiChars = emoji.Groups[2].Value.ToCharArray();
                //foreach (var item in currEmojiChars)
                //{
                //    currEmojiThresholdSum += item;
                //}
                
                if (currEmojiThresholdSum >= coolThresholdSum)
                {
                    Console.WriteLine(emoji);
                }
            }
        }
    }
}
