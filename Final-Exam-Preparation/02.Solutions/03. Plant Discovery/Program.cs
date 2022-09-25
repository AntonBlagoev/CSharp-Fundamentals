using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plantDict = new Dictionary<string, Plant>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputPlant = Console.ReadLine().Split("<->");
                plantDict.Add(inputPlant[0], new Plant(int.Parse(inputPlant[1]), 0.0, 0));
            }

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Exhibition")
            {
                string[] commands = Regex.Split(inputCommands, @":\s|\s\-\s");
                //string[] commands = inputCommands.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (!plantDict.ContainsKey(commands[1]))
                {
                    Console.WriteLine("error");
                    continue;
                }

                switch (commands[0])
                {
                    case "Rate":
                        Rate(commands[1], double.Parse(commands[2]), plantDict);
                        break;
                    case "Update":
                        Update(commands[1], int.Parse(commands[2]), plantDict);
                        break;
                    case "Reset":
                        Reset(commands[1], plantDict);
                        break;
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantDict)
            {
                double averageRating = 0.0;
                if (plant.Value.Rating != 0)
                {
                    averageRating = plant.Value.Rating / plant.Value.RatingCount;
                }
                
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {averageRating:f2}");
            }

        }

        static void Rate(string plant, double rating, Dictionary<string, Plant> plantDict)
        {
            plantDict[plant].Rating += rating;
            plantDict[plant].RatingCount++;
        }
        static void Update(string plant, int rarity, Dictionary<string, Plant> plantDict)
        {
            plantDict[plant].Rarity = rarity;
        }
        static void Reset(string plant, Dictionary<string, Plant> plantDict)
        {
            plantDict[plant].Rating = 0;
            plantDict[plant].RatingCount = 0;
        }
    }
}
class Plant
{
    public int Rarity { get; set; }
    public double Rating { get; set; }
    public int RatingCount { get; set; }
    public Plant(int rarity, double rating, int ratingCount)
    {
        Rarity = rarity;
        Rating = rating;
        RatingCount = ratingCount;
    }
}
