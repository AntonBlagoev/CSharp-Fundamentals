using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treasures = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(" ").ToArray();

                if (commands[0] == "Yohoho!")
                {
                    break;
                }

                if (commands[0] == "Loot")
                {
                    for (int i = 1; i < commands.Length; i++)
                    {
                        if (!treasures.Contains(commands[i]))
                        {
                            treasures.Insert(0, commands[i]);
                        }
                    }

                }
                else if (commands[0] == "Drop")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < treasures.Count)
                    {
                        string itemToDrop = treasures[index];
                        treasures.RemoveAt(index);
                        treasures.Add(itemToDrop);
                    }

                }
                else if (commands[0] == "Steal")
                {
                    int count = int.Parse(commands[1]);
                    List<string> stolenItems = new List<string>();

                    if (count > treasures.Count)
                    {
                        count = treasures.Count;
                    }
                    int startIndex = treasures.Count - 1;
                    int endIndex = treasures.Count - count;

                    for (int i = startIndex; i >= endIndex; i--)
                    {
                        stolenItems.Insert(0, treasures[i]);
                        treasures.RemoveAt(i);
                    }
                    Console.WriteLine(string.Join(", ", stolenItems));

                }
            }

            double itemsLenght = 0;

            for (int i = 0; i < treasures.Count; i++)
            {
                itemsLenght += treasures[i].Length;
            }

            double averageGain = itemsLenght / treasures.Count;

            if (averageGain > 0)
            {
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }

        }
    }
}
