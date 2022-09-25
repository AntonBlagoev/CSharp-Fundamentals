using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            MatchCollection destinationsMatches = Regex.Matches(inputString, @"([=\/])([A-Z][A-Za-z]{2,})\1");

            int travalePoints = destinationsMatches.Select(x => x.Groups[2].Value.Length).Sum();

            Console.WriteLine($"Destinations: {string.Join(", ", destinationsMatches.Select(x => x.Groups[2].Value))}");
            Console.WriteLine($"Travel Points: {travalePoints}");

        }
    }
}
