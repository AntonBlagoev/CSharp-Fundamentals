using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "end")
                {
                    break;
                }

                switch (commands[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        inputList.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commands[1]);
                        inputList.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int numberToRemoveAt = int.Parse(commands[1]);
                        inputList.RemoveAt(numberToRemoveAt);
                        break;
                    case "Insert":
                        int indexToInsert = int.Parse(commands[2]);
                        int numberToInsert = int.Parse(commands[1]);
                        inputList.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}

/* Create a program that reads a list of integers. Then until you receive "end", you will receive different commands:
 * •	Add {number}: add a number to the end of the list.
 * •	Remove {number}: remove a number from the list.
 * •	RemoveAt {index}: remove a number at a given index.
 * •	Insert {number} {index}: insert a number at a given index.
 * Note: All the indices will be valid!
 * When you receive the "end" command, print the final state of the list (separated by spaces).
 * 
 * Input
 * 4 19 2 53 6 43
 * Add 3
 * Remove 2
 * RemoveAt 1
 * Insert 8 3
 * end
 * 
 * Output
 * 4 53 6 8 43 3
 * 
 * Input
 * 23 1 456 63 32 87 9 32
 * Remove 5
 * Add 1
 * Insert 14 2
 * RemoveAt 3
 * Add 34
 * end
 * 
 * Output
 * 23 1 14 63 32 87 9 32 1 34
 * 
 * 
 */
