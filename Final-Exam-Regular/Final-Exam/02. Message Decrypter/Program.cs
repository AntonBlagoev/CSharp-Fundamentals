using System;
using System.Text.RegularExpressions;

namespace _02._Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();

                Match matches = Regex.Match(message, @"^([$]|[%])([A-Z][a-z]{2,})\1[:]\s\[(\d+)\]([\|])\[(\d+)\]\4\[(\d+)\]\4$");

                if (!matches.Success)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }

                string tag = matches.Groups[2].Value;

                char firstChar = (char)int.Parse(matches.Groups[3].Value);
                char secondChar = (char)int.Parse(matches.Groups[5].Value);
                char thirdChar = (char)int.Parse(matches.Groups[6].Value);

                string decryptedMessage = firstChar.ToString() + secondChar.ToString() + thirdChar.ToString();
                
                Console.WriteLine($"{tag}: {decryptedMessage}");
            }
        }
    }
}
