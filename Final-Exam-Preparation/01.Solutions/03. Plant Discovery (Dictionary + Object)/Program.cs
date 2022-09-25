using System;
using System.Collections.Generic;


namespace _03._Plant_Discovery__Dictionary___Object_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plantsDict = new Dictionary<string, Plant>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                plantsDict.Add(input[0], new Plant(int.Parse(input[1]), 0, 0));
            }
            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Exhibition")
            {
                string[] commands = inputCommands.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries); // Split(new char[] { ':', '-' })

                // Match matches = Regex.Match(inputCommands, @"([A-Za-z]+):\s+([A-Za-z]+)(\s+\-\s+)?([0-9]+)?");
                if (!plantsDict.ContainsKey(commands[1]))
                {
                    Console.WriteLine("error");
                    continue;
                }

                switch (commands[0])
                {
                    case "Rate":
                        Rate(commands[1], int.Parse(commands[2]), plantsDict);
                        break;
                    case "Update":
                        Update(commands[1], int.Parse(commands[2]), plantsDict);
                        break;
                    case "Reset":
                        Reset(commands[1], plantsDict);
                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantsDict)
            {
                double average = double.Parse(plant.Value.Rating.ToString()) / double.Parse(plant.Value.CountRating.ToString());
                if (double.Equals(double.NaN, average))
                {
                    average = 0;
                }
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {average:f2}");
            }
        }


        static void Rate(string plantName, int rating, Dictionary<string, Plant> plantsDict)
        {
            plantsDict[plantName].Rating += rating;
            plantsDict[plantName].CountRating += 1;
        }
        static void Update(string plantName, int rarity, Dictionary<string, Plant> plantsDict)
        {
            plantsDict[plantName].Rarity = rarity;
        }
        static void Reset(string plantName, Dictionary<string, Plant> plantsDict)
        {
            plantsDict[plantName].Rating = 0;
            plantsDict[plantName].CountRating = 0;
        }
    }
}

class Plant
{
    public int Rarity { get; set; }
    public int Rating { get; set; }
    public int CountRating { get; set; }
    public Plant(int rarity, int rating, int countRating)
    {
        Rarity = rarity;
        Rating = rating;
        CountRating = countRating;
    }
}
