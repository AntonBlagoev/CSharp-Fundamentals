using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroesDict = new Dictionary<string, Hero>();

            int numberOfHeroes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] inputHeroes = Console.ReadLine().Split();
                heroesDict.Add(inputHeroes[0], new Hero(int.Parse(inputHeroes[1]), int.Parse(inputHeroes[2])));
            }
            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "End")
            {
                string[] commands = inputCommands.Split(" - ");
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
                Console.WriteLine($"  HP: {hero.Value.HitPoints}");
                Console.WriteLine($"  MP: {hero.Value.ManaPoints}");

            }
        }

        static void CastSpell(string heroName, int neededMP, string spellName, Dictionary<string, Hero> heroesDict)
        {
            if (heroesDict[heroName].ManaPoints >= neededMP)
            {
                heroesDict[heroName].ManaPoints -= neededMP;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesDict[heroName].ManaPoints} MP!");
                return;
            }
            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
        }

        static void TakeDamage(string heroName, int damage, string attacker, Dictionary<string, Hero> heroesDict)
        {
            heroesDict[heroName].HitPoints -= damage;
            if (heroesDict[heroName].HitPoints > 0)
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesDict[heroName].HitPoints} HP left!");
                return;
            }
            heroesDict.Remove(heroName);
            Console.WriteLine($"{heroName} has been killed by {attacker}!");
        }

        static void Recharge(string heroName, int amount, Dictionary<string, Hero> heroesDict)
        {
            if (heroesDict[heroName].ManaPoints + amount > 200)
            {
                amount = 200 - heroesDict[heroName].ManaPoints;
            }
            heroesDict[heroName].ManaPoints += amount;
            Console.WriteLine($"{heroName} recharged for {amount} MP!");
        }

        static void Heal(string heroName, int amount, Dictionary<string, Hero> heroesDict)
        {
            if (heroesDict[heroName].HitPoints + amount > 100)
            {
                amount = 100 - heroesDict[heroName].HitPoints;
            }
            heroesDict[heroName].HitPoints += amount;
            Console.WriteLine($"{heroName} healed for {amount} HP!");
        }
    }
}

class Hero
{
    public int HitPoints { get; set; }
    public int ManaPoints { get; set; }
    public Hero(int hitPoints, int manaPoints)
    {
        HitPoints = hitPoints;
        ManaPoints = manaPoints;
    }
}
