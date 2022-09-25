using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII__List___Object_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroesList = new List<Hero>();

            int numberOfHeroes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] input = Console.ReadLine().Split();

                heroesList.Add(new Hero(input[0], int.Parse(input[1]), int.Parse(input[2])));
            }

            string inputCommand = string.Empty;
            while ((inputCommand = Console.ReadLine()) != "End")
            {
                string[] commands = inputCommand.Split(" - ");

                switch (commands[0])
                {
                    case "CastSpell":
                        CastSpell(commands[1], int.Parse(commands[2]), commands[3], heroesList);
                        break;

                    case "TakeDamage":
                        TakeDamage(commands[1], int.Parse(commands[2]), commands[3], heroesList);
                        break;

                    case "Recharge":
                        Recharge(commands[1], int.Parse(commands[2]), heroesList);
                        break;

                    case "Heal":
                        Heal(commands[1], int.Parse(commands[2]), heroesList);
                        break;
                }
            }

            foreach (var hero in heroesList)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"HP: {hero.HitPoints}");
                Console.WriteLine($"MP: {hero.ManaPoints}");
            }

        }

        static void CastSpell(string name, int neededMP, string spellName, List<Hero> heroesList)
        {
            Hero hero = heroesList.First(x => x.Name == name);

            if (hero.ManaPoints >= neededMP)
            {
                hero.ManaPoints -= neededMP;
                Console.WriteLine($"{name} has successfully cast {spellName} and now has {hero.ManaPoints} MP!");
            }
            else
            {
                Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
            }
        }

        static void TakeDamage(string name, int damage, string attacker, List<Hero> heroesList)
        {
            Hero hero = heroesList.First(x => x.Name == name);
            if (hero.HitPoints > damage)
            {
                hero.HitPoints -= damage;
                Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {hero.HitPoints} HP left!");
            }
            else
            {
                heroesList.Remove(hero);
                Console.WriteLine($"{name} has been killed by {attacker}!");
            }
        }
        static void Recharge(string name, int amount, List<Hero> heroesList)
        {
            Hero hero = heroesList.First(x => x.Name == name);
            if (hero.ManaPoints + amount > 200)
            {
                amount = 200 - hero.ManaPoints;
                hero.ManaPoints = 200;
            }
            else
            {
                hero.ManaPoints += amount;
            }
            Console.WriteLine($"{name} recharged for {amount} MP!");
        }

        static void Heal(string name, int amount, List<Hero> heroesList)
        {
            Hero hero = heroesList.First(x => x.Name == name);

            if (hero.HitPoints + amount > 100)
            {
                amount = 100 - hero.HitPoints;
                hero.HitPoints = 100;
            }
            else
            {
                hero.HitPoints += amount;
            }
            Console.WriteLine($"{name} healed for {amount} HP!");
        }
    }
}
class Hero
{
    public string Name { get; set; }
    public int HitPoints { get; set; }
    public int ManaPoints { get; set; }
    public Hero(string name, int hitPoints, int manaPoints)
    {
        Name = name;
        HitPoints = hitPoints;
        ManaPoints = manaPoints;
    }
}
