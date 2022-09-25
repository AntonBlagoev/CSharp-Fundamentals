using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII__Dictionary___List_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> heroesDict = new Dictionary<string, List<int>>();

            int numberOfHeroes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] input = Console.ReadLine().Split();
                
                string heroName = input[0];
                int heroHitPoints = int.Parse(input[1]);
                int heroManaPoints = int.Parse(input[2]);

                heroesDict.Add(heroName, new List<int> { heroHitPoints, heroManaPoints });
                //heroesDict[heroName].Add(heroHitPoints);
                //heroesDict[heroName].Add(heroManaPoints);
            }

            string inputCommand = string.Empty;
            while ((inputCommand = Console.ReadLine()) != "End")
            {
                string[] commands = inputCommand.Split(" - ");

                switch (commands[0])
                {
                    case "CastSpell":
                        CastSpell(commands[1], int.Parse(commands[2]), commands[3], heroesDict);
                        break;

                    case "TakeDamage":
                        TakeDamage(commands[1], int.Parse(commands[2]), commands[3], heroesDict);
                        break;

                    case "Recharge":
                        Recharge(commands[1], int.Parse(commands[2]), heroesDict);
                        break;

                    case "Heal":
                        Heal(commands[1], int.Parse(commands[2]), heroesDict);
                        break;
                }
            }

            foreach (var hero in heroesDict)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"HP: {hero.Value[0]}");
                Console.WriteLine($"MP: {hero.Value[1]}");
            }
        }

        static void CastSpell(string heroName, int neededMP, string spellName, Dictionary<string, List<int>> heroesDict)
        {
            if (heroesDict[heroName][1] >= neededMP)
            {
                heroesDict[heroName][1] -= neededMP;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesDict[heroName][1]} MP!");
                return;
            }
            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
        }

        static void TakeDamage(string heroName, int damage, string attacker, Dictionary<string, List<int>> heroesDict)
        {
            if (heroesDict[heroName][0] > damage)
            {
                heroesDict[heroName][0] -= damage;
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesDict[heroName][0]} HP left!");
                return;
            }
            Console.WriteLine($"{heroName} has been killed by {attacker}!");
            heroesDict.Remove(heroName);
        }

        static void Recharge(string heroName, int amount, Dictionary<string, List<int>> heroesDict)
        {
            if (heroesDict[heroName][1] + amount > 200)
            {
                amount = 200 - heroesDict[heroName][1];
                heroesDict[heroName][1] = 200;
            }
            else
            {
                heroesDict[heroName][1] += amount;
            }
            Console.WriteLine($"{heroName} recharged for {amount} MP!");
        }

        static void Heal(string heroName, int amount, Dictionary<string, List<int>> heroesDict)
        {
            if (heroesDict[heroName][0] + amount > 100)
            {
                amount = 100 - heroesDict[heroName][0];
                heroesDict[heroName][0] = 100;
            }
            else
            {
                heroesDict[heroName][0] += amount;
            }
            Console.WriteLine($"{heroName} healed for {amount} HP!");
        }
    }
}
