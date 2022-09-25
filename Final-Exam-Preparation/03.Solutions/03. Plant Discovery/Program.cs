using System;
using System.Collections.Generic;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plantsDict = new Dictionary<string, Plant>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputPlant = Console.ReadLine().Split("<->");
                plantsDict.Add(inputPlant[0], new Plant(int.Parse(inputPlant[1]), 0, 0));
            }

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Exhibition")
            {
                string[] commands = inputCommands.Split(new[] { ": ", " - " }, StringSplitOptions.None);

                if (!plantsDict.ContainsKey(commands[1]))
                {
                    Console.WriteLine("error");
                    continue;
                }
                switch (commands[0])
                {
                    case "Rate":
                        Rate(commands[1], double.Parse(commands[2]), plantsDict);
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
            foreach (var item in plantsDict)
            {
                double averagerating = 0.0;
                if (item.Value.Rating > 0)
                {
                    averagerating = item.Value.Rating / item.Value.RatingCount;
                }
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {averagerating:f2}");
            }
        }

        static void Rate(string plant, double rating, Dictionary<string, Plant> plantsDict)
        {
            plantsDict[plant].Rating += rating;
            plantsDict[plant].RatingCount++;
        }

        static void Update(string plant, int newRarity, Dictionary<string, Plant> plantsDict)
        {
            plantsDict[plant].Rarity = newRarity;
        }

        static void Reset(string plant, Dictionary<string, Plant> plantsDict)
        {
            plantsDict[plant].Rating = 0;
            plantsDict[plant].RatingCount = 0;
        }
    }
}

class Plant
{
    public int Rarity { get; set; }
    public double Rating { get; set; }
    public int RatingCount { get; set; }
    public Plant(int rarity, int rating, int ratingCount)
    {
        Rarity = rarity;
        Rating = rating;
        RatingCount = ratingCount;
    }
}