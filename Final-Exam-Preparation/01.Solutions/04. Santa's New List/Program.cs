using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Santa_s_New_List
{
    class Program
    {
        private static object dictionary;

        static void Main(string[] args)
        {
            Dictionary<string, int> childrenList = new Dictionary<string, int>();
            Dictionary<string, int> toysList = new Dictionary<string, int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] commands = input.Split("->");

                if (commands[0] == "Remove")
                {
                    childrenList.Remove(commands[1]);
                }
                else
                {
                    if (!childrenList.ContainsKey(commands[0]))
                    {
                        childrenList.Add(commands[0], 0);
                    }
                    childrenList[commands[0]] += int.Parse(commands[2]);

                    if (!toysList.ContainsKey(commands[1]))
                    {
                        toysList.Add(commands[1], 0);
                    }
                    toysList[commands[1]] += int.Parse(commands[2]);

                }
            }

            Console.WriteLine("Children:");
            foreach (var child in childrenList
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{child.Key} -> {child.Value}");
            }
            Console.WriteLine("Presents:");
            foreach (var toy in toysList)
            {
                Console.WriteLine($"{toy.Key} -> {toy.Value}");
            }

        }
    }
}
