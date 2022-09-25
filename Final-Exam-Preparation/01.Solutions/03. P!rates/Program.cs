using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> citiesDict = new Dictionary<string, City>();

            string inputSail = string.Empty;
            while ((inputSail = Console.ReadLine()) != "Sail")
            {
                string[] sailCommands = inputSail.Split("||");
                if (citiesDict.ContainsKey(sailCommands[0]))
                {
                    citiesDict[sailCommands[0]].Population += int.Parse(sailCommands[1]);
                    citiesDict[sailCommands[0]].Gold += int.Parse(sailCommands[2]);
                }
                else
                {
                    citiesDict.Add(sailCommands[0], new City(int.Parse(sailCommands[1]), int.Parse(sailCommands[2])));
                }
            }
            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "End")
            {
                string[] commands = inputCommands.Split("=>");

                switch (commands[0])
                {
                    case "Plunder":
                        Plunder(commands[1], int.Parse(commands[2]), int.Parse(commands[3]), citiesDict);
                        break;
                    case "Prosper":
                        Prosper(commands[1], int.Parse(commands[2]), citiesDict);
                        break;
                }
            }
            if (citiesDict.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesDict.Count} wealthy settlements to go to:");
                foreach (var city in citiesDict)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        static void Plunder(string town, int people, int gold, Dictionary<string, City> citiesDict)
        {
            citiesDict[town].Population -= people;
            citiesDict[town].Gold -= gold;

            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

            if (citiesDict[town].Population <= 0 || citiesDict[town].Gold <= 0)
            {
                Console.WriteLine($"{town} has been wiped off the map!");
                citiesDict.Remove(town);
            }

        }
        static void Prosper(string town, int gold, Dictionary<string, City> citiesDict)
        {
            if (gold < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
                return;
            }
            citiesDict[town].Gold += gold;
            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {citiesDict[town].Gold} gold.");
        }
    }
}

class City
{
    public int Population { get; set; }
    public int Gold { get; set; }
    public City(int population, int gold)
    {
        Population = population;
        Gold = gold;
    }
}