using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inputString, @"([=]|[/])([A-Z][A-Za-z]{2,})\1"); // @"([\/=])([A-Z][A-Za-z]{2,})\1"

            int travelPoints = 0;

            string[] destinations = matches.Select(x => x.Groups[2].Value).ToArray();
            travelPoints = destinations.Select(x => x.Length).Sum();

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");

            //List<string> destinationList = new List<string>();
            //foreach (Match destination in matches)
            //{
            //    destinationList.Add(destination.Groups[2].Value);
            //    travelPoints += destination.Groups[2].Value.Length;
            //}
            //Console.Write("Destinations: ");
            //Console.WriteLine(string.Join(", ", destinationList));
            //Console.WriteLine($"Travel Points: {travelPoints}");

        }
    }
}
