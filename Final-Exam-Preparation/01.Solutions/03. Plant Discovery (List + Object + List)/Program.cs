using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery__List___Object___List_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plantsList = new List<Plant>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");

                var inputPlant = plantsList.FirstOrDefault(x => x.Name == input[0]);
                if (inputPlant != null)
                {
                    plantsList.Remove(inputPlant);
                }
                plantsList.Add(new Plant(input[0], int.Parse(input[1]), new List<int>()));
                
            }
            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Exhibition")
            {
                string[] commands = inputCommands.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries); // Split(new char[] { ':', '-' })

                //Match matches = Regex.Match(inputCommands, @"([A-Za-z]+):\s+([A-Za-z]+)(\s+\-\s+)?([0-9]+)?");

                var plant = plantsList.FirstOrDefault(x => x.Name == commands[1]);
             
                if (plant == null)
                {
                    Console.WriteLine("error");
                    continue;
                }

                switch (commands[0])
                {
                    case "Rate":
                        Rate(commands[1], int.Parse(commands[2]), plantsList);
                        break;
                    case "Update":
                        Update(commands[1], int.Parse(commands[2]), plantsList);
                        break;
                    case "Reset":
                        Reset(commands[1], plantsList);
                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (Plant plant in plantsList)
            {
                double sumRating = plant.Rating.Sum(x => x);
                int countRating = plant.Rating.Count;

                double average = sumRating / countRating;
                if (double.Equals(double.NaN, average))
                {
                    average = 0;
                }

                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {average:f2}");
            }
        }

        static void Reset(string plantName, List<Plant> plantsList)
        {
            Plant plant = plantsList.First(x => x.Name == plantName);
            plant.Rating.Clear();
        }

        static void Update(string plantName, int rarity, List<Plant> plantsList)
        {
            Plant plant = plantsList.First(x => x.Name == plantName);
            plant.Rarity = rarity;
        }

        static void Rate(string plantName, int rating, List<Plant> plantsList)
        {
            Plant plant = plantsList.First(x => x.Name == plantName);
            plant.Rating.Add(rating);
        }
    }
}

class Plant
{
    public string Name { get; set; }
    public int Rarity { get; set; }
    public List<int> Rating { get; set; }
    public Plant(string name, int rarity, List<int> rating)
    {
        Name = name;
        Rarity = rarity;
        Rating = rating;
    }
}