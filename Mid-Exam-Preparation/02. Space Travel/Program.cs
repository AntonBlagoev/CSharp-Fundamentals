using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Space_Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] routeArr = Console.ReadLine().Split("||").ToArray();
            int totalFuel = int.Parse(Console.ReadLine());
            int totalAmmunitions = int.Parse(Console.ReadLine());

            for (int i = 0; i < routeArr.Length; i++)
            {
                List<string> commands = routeArr[i].Split(" ").ToList();

                if (commands[0] == "Travel")
                {
                    int distance = int.Parse(commands[1]);
                    if (totalFuel >= distance)
                    {
                        totalFuel -= distance;
                        Console.WriteLine($"The spaceship travelled {distance} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        break;
                    }
                }

                else if (commands[0] == "Enemy")
                {
                    int enemyPoints = int.Parse(commands[1]);
                    if (totalAmmunitions >= enemyPoints)
                    {
                        totalAmmunitions -= enemyPoints;
                        Console.WriteLine($"An enemy with {enemyPoints} armour is defeated.");
                    }
                    else
                    {
                        if (totalFuel >= (enemyPoints * 2))
                        {
                            totalFuel -= (enemyPoints * 2);
                            Console.WriteLine($"An enemy with {enemyPoints} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            break;
                        }
                    }
                }

                else if (commands[0] == "Repair")
                {
                    int amountOfRepairs = int.Parse(commands[1]);
                    totalAmmunitions += (amountOfRepairs * 2);
                    totalFuel += amountOfRepairs;

                    Console.WriteLine($"Ammunitions added: {(amountOfRepairs * 2)}.");
                    Console.WriteLine($"Fuel added: {amountOfRepairs}.");
                }

                else if (commands[0] == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    break;
                }



            }


        }
    }
}
