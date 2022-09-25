using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List__re_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                List<string> commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (commands[0] + " " + commands[1] == "Go Shopping!")
                {
                    break;
                }

                if (commands[0] == "Urgent")
                {
                    string item = commands[1];
                    if (!shoppingList.Contains(item))
                    {
                        shoppingList.Insert(0, item);
                    }
                  
                }

                else if (commands[0] == "Unnecessary")
                {
                    string unnecenssaryItem = commands[1];

                    if (shoppingList.Contains(unnecenssaryItem))
                    {
                        shoppingList.Remove(unnecenssaryItem);
                    }



                }
                else if (commands[0] == "Correct")
                {
                    string oldItem = commands[1];
                    string newItem = commands[2];
                    if (shoppingList.Contains(oldItem))
                    {
                        int index = shoppingList.IndexOf(oldItem);
                        
                        shoppingList.Remove(oldItem);
                        shoppingList.Insert(index, newItem);
                    }
                }

                else if (commands[0] == "Rearrange")
                {
                    string item = commands[1];
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);

                    }
                }
            }


            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
