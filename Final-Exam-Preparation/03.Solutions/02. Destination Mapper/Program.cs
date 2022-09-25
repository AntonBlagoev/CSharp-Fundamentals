using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            MatchCollection matches = Regex.Matches(message, @"([=]|[\/])([A-Z][a-zA-Z]{2,})\1");

            int travelPoints = matches.Select(x => x.Groups[2].Value.Length).Sum();

            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", matches.Select(x => x.Groups[2].Value)));
            Console.WriteLine($"Travel Points: {travelPoints}");

        }
    }
}
