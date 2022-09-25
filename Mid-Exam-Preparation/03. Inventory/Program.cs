using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                List<string> commands = Console.ReadLine().Split(" - ").ToList();

                if (commands[0] == "Craft!")
                {
                    break;
                }

                if (commands[0] == "Collect")
                {
                    if (!inputList.Contains(commands[1]))
                    {
                        inputList.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Drop")
                {
                    if (inputList.Contains(commands[1]))
                    {
                        inputList.Remove(commands[1]);
                    }
                }
                else if (commands[0] == "Combine Items")
                {
                    List<string> combineList = commands[1].Split(":").ToList();
                    string oldItem = combineList[0];
                    string newItem = combineList[1];

                    if (inputList.Contains(oldItem))
                    {
                        int index = inputList.IndexOf(oldItem);
                        inputList.Insert(index + 1, newItem);
                    }
                }
                else if (commands[0] == "Renew")
                {
                    if (inputList.Contains(commands[1]))
                    {
                        inputList.Remove(commands[1]);
                        inputList.Add(commands[1]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", inputList));
        }
    }
}
