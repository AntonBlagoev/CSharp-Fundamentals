using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"([\|#])([a-z-A-Z]+\s?[a-zA-Z]+?)\1([0-9]{2}/[0-9]{2}/[0-9]{2})\1(\d+)\1");

            int totalCaloriesSum = matches.Select(x => int.Parse(x.Groups[4].Value)).Sum();
            int days = totalCaloriesSum / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups[2].Value}, Best before: {item.Groups[3].Value}, Nutrition: {int.Parse(item.Groups[4].Value)}");
            }
        }
    }
}
