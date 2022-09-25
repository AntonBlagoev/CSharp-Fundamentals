using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "End")
                {
                    break;
                }

                if (commands[0] == "Add")
                {
                    int addNumber = int.Parse(commands[1]);
                    listOfNumbers.Add(addNumber);
                }
                else if (commands[0] == "Insert")
                {
                    int indexToInsert = int.Parse(commands[2]);
                    int numberToInsert = int.Parse(commands[1]);
                   
                    if (indexToInsert >= 0 && indexToInsert <= listOfNumbers.Count)
                    {
                        listOfNumbers.Insert(indexToInsert, numberToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commands[0] == "Remove")
                {
                    int indexToRemoveAt = int.Parse(commands[1]);
                    if (indexToRemoveAt >= 0 && indexToRemoveAt < listOfNumbers.Count)
                    {
                        listOfNumbers.RemoveAt(indexToRemoveAt);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (commands[0] == "Shift" && commands[1] == "left")
                {
                    int indexToMove = int.Parse(commands[2]);

                    if (indexToMove >= listOfNumbers.Count - 1 && indexToMove < 0 || listOfNumbers.Count == 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        for (int i = 0; i < indexToMove; i++)
                        {
                            int firstIndex = listOfNumbers[0];
                            listOfNumbers.Add(firstIndex);
                            listOfNumbers.RemoveAt(0);
                        }
                    }
                }
                else if (commands[0] == "Shift" && commands[1] == "right")
                {
                    int indexToMove = int.Parse(commands[2]);

                    if (indexToMove >= listOfNumbers.Count - 1 && indexToMove < 0 || listOfNumbers.Count == 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        for (int i = 0; i < indexToMove; i++)
                        {
                            int lastIndex = listOfNumbers[listOfNumbers.Count - 1];
                            listOfNumbers.Insert(0, lastIndex);
                            listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}

/* The first input line will hold a list of integers. Until we receive the "End" command, we will be given operations we have to apply to the list.
 * The possible commands are:
 * •	Add {number} – add the given number to the end of the list
 * •	Insert {number} {index} – insert the number at the given index
 * •	Remove {index} – remove the number at the given index
 * •	Shift left {count} – first number becomes last. This has to be repeated the specified number of times
 * •	Shift right {count} – last number becomes first. To be repeated the specified number of times
 * Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".
 * 
 * Examples
 * 
 * Input
 * 1 23 29 18 43 21 20
 * Add 5
 * Remove 5
 * Shift left 3
 * Shift left 1
 * End
 * 
 * Output
 * 43 20 5 1 23 29 18
 * 
 * Input
 * 5 12 42 95 32 1
 * Insert 3 0
 * Remove 10
 * Insert 8 6
 * Shift right 1
 * Shift left 2
 * End
 * 
 * Output
 * Invalid index
 * 5 12 42 95 32 8 1 3
 * 
 */