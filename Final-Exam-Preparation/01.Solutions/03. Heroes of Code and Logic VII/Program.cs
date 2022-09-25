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
                string[] input = Console.ReadLine().Split();
                string heroName = input[0];
                int heroHitPoints = int.Parse(input[1]);
                int heroManaPoints = int.Parse(input[2]);

                heroesDict.Add(heroName, new Hero(heroHitPoints, heroManaPoints));
            }

            string inputCommand = string.Empty;
            while ((inputCommand = Console.ReadLine()) != "End")
            {
                string[] commands = inputCommand.Split(" - ");
                
                switch (commands[0])
                {
                    case "CastSpell":
                        string heroNameSpell = commands[1];
                        int neededForSpellMP = int.Parse(commands[2]);
                        string spellName = commands[3];
                        if (heroesDict[heroNameSpell].ManaPoints >= neededForSpellMP)
                        {
                            heroesDict[heroNameSpell].ManaPoints -= neededForSpellMP;
                            Console.WriteLine($"{heroNameSpell} has successfully cast {spellName} and now has {heroesDict[heroNameSpell].ManaPoints} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroNameSpell} does not have enough MP to cast {spellName}!");
                        }
                        break;

                    case "TakeDamage":
                        string heroNameDamage = commands[1];
                        int damage = int.Parse(commands[2]);
                        string attacker = commands[3];
                        if (heroesDict[heroNameDamage].HitPoints > damage)
                        {
                            heroesDict[heroNameDamage].HitPoints -= damage;
                            Console.WriteLine($"{heroNameDamage} was hit for {damage} HP by {attacker} and now has {heroesDict[heroNameDamage].HitPoints} HP left!");
                        }
                        else
                        {
                            heroesDict.Remove(heroNameDamage);
                            Console.WriteLine($"{heroNameDamage} has been killed by {attacker}!");
                        }
                        break;

                    case "Recharge":
                        string heroNameRecharge = commands[1];
                        int amountRecharge = int.Parse(commands[2]);
                        
                        if (heroesDict[heroNameRecharge].ManaPoints + amountRecharge > 200)
                        {
                            amountRecharge = 200 - heroesDict[heroNameRecharge].ManaPoints;
                            heroesDict[heroNameRecharge].ManaPoints = 200;
                        }
                        else
                        {
                            heroesDict[heroNameRecharge].ManaPoints += amountRecharge;
                        }
                        Console.WriteLine($"{heroNameRecharge} recharged for {amountRecharge} MP!");
                        break;

                    case "Heal":
                        string heroNameHeal = commands[1];
                        int amountHeal = int.Parse(commands[2]);
                        if (heroesDict[heroNameHeal].HitPoints + amountHeal > 100)
                        {
                            amountHeal = 100 - heroesDict[heroNameHeal].HitPoints;
                            heroesDict[heroNameHeal].HitPoints = 100;
                        }
                        else
                        {
                            heroesDict[heroNameHeal].HitPoints += amountHeal;
                        }
                        Console.WriteLine($"{heroNameHeal} healed for {amountHeal} HP!");
                        break;
                }
            }

            foreach (var item in heroesDict)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"HP: {item.Value.HitPoints}");
                Console.WriteLine($"MP: {item.Value.ManaPoints}");
            }

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
