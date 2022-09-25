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

            MatchCollection matches = Regex.Matches(input, @"([\|]|[\#])([A-Za-z]+\s?[A-Za-z]+)\1([0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(\d+)\1");

            int totalCalories = matches.Select(x => int.Parse(x.Groups[4].Value)).Sum();
            int numberOfDays = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {numberOfDays} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups[2].Value}, Best before: {match.Groups[3].Value}, Nutrition: {match.Groups[4].Value}");
            }
        }
    }
}
