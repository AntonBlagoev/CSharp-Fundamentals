using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|").ToArray();

            int health = 100;
            int bitcoins = 0;
            bool killed = false;
            int bestRoom = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] eachRoom = rooms[i].Split().ToArray();

                string command = eachRoom[0];
                int amount = int.Parse(eachRoom[1]);

                if (command == "potion")
                {

                    if (health + amount > 100)
                    {
                        amount = 100 - health;
                        health = 100;

                    }
                    else
                    {
                        health += amount;
                    }
                    bestRoom++;
                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += amount;
                    bestRoom++;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }

                else
                {
                    string monster = eachRoom[0];
                    int attack = int.Parse(eachRoom[1]);
                    health -= attack;
                    bestRoom++;

                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        killed = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {monster}.");

                    }
                }


            }

            if (!killed)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");

            }

        }
    }
}
