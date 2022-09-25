using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inputString, @"([|]|[#])([A-Za-z]+\s?[A-Za-z]+)\1([0-9]{2}/[0-9]{2}/[0-9]{2})\1(\d+)\1");

            //int totaCalories = matches.Select(x => int.Parse(x.Groups[4].Value)).Sum();

            int totaCalories = 0;
            foreach (Match match in matches)
            {
                totaCalories += int.Parse(match.Groups[4].Value);
            }

            int numberOfDays = totaCalories / 2000;
            Console.WriteLine($"You have food to last you for: {numberOfDays} days!");

            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups[2].Value}, Best before: {item.Groups[3].Value}, Nutrition: {item.Groups[4].Value}");
            }
        }
    }
}
