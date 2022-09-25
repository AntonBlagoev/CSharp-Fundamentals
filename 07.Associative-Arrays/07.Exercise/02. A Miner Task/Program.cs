using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resDict = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!resDict.ContainsKey(resource))
                {
                    resDict.Add(resource, 0);
                }
                resDict[resource] += quantity;
            }

            foreach (var item in resDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
/* 2.	A Miner Task
 * 
 * You will be given a sequence of strings, each on a new line.
 * Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper and so on) and every even - quantity.
 * Your task is to collect the resources and print them each on a new line.
 * Print the resources and their quantities in the following format:
 * "{resource} –> {quantity}"
 * The quantities will be in the range [1… 2 000000000].
 * 
 * Input
 * Gold
 * 155
 * Silver
 * 10
 * Copper
 * 17
 * stop
 * 
 * Output
 * Gold -> 155
 * Silver -> 10
 * Copper -> 17
 * 
 * Input
 * gold
 * 155
 * silver
 * 10
 * copper
 * 17
 * gold
 * 15
 * stop
 * 
 * Output
 * gold -> 170
 * silver -> 10
 * copper -> 17
 * 
 * 
 * 
 * 
 * 
 * 
 */
