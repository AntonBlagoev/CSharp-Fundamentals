using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());

            bool isLost = false;

            while (true)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "Retire")
                {
                    break;
                }

                if (commands[0] == "Fire")
                {
                    int index = int.Parse(commands[1]);
                    int damage = int.Parse(commands[2]);

                    if (index >= 0 && index < warShip.Count)
                    {
                        warShip[index] -= damage;

                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            isLost = true;
                            break;
                        }
                    }
                }
                else if (commands[0] == "Defend")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    int damage = int.Parse(commands[3]);

                    if (startIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                isLost = true;
                                break;
                            }
                        }
                    }
                }
                else if (commands[0] == "Repair")
                {
                    int index = int.Parse(commands[1]);
                    int health = int.Parse(commands[2]);

                    if (index >= 0 && index < pirateShip.Count)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                }
                else if (commands[0] == "Status")
                {
                    int count = 0;
                    double minHealth = maxHealth * 0.2;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < minHealth)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
            }
            if (!isLost)
            {
                int pirateShipSum = pirateShip.Sum();
                int warShipSum = warShip.Sum();

                Console.WriteLine($"Pirate ship status: {pirateShipSum}");
                Console.WriteLine($"Warship status: {warShipSum}");
            }


        }
    }
}
