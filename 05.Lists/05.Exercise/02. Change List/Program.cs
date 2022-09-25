using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfIntigers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "end") 
                {
                    break;
                }

                if (commands[0] == "Delete")
                {
                    int numberToDelete = int.Parse(commands[1]);
                    listOfIntigers.RemoveAll(nums => nums == numberToDelete);
                }

                else if (commands[0] == "Insert")
                {
                    int indexToInsert = int.Parse(commands[2]);
                    int numberToInsert = int.Parse(commands[1]);
                    listOfIntigers.Insert(indexToInsert, numberToInsert); 
                }
            }
            Console.WriteLine(string.Join(" ", listOfIntigers));
        }
    }
}
/* Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
 * Your program may receive the following commands:
 * •	Delete {element} – delete all elements in the array, which are equal to the given element.
 * •	Insert {element} {position} – insert the element at the given position.
 * You should exit the program when you receive the "end" command. Print all numbers in the array, separated by a single whitespace.
 * 
 * Input
 * 1 2 3 4 5 5 5 6
 * Delete 5
 * Insert 10 1
 * Delete 5
 * end
 * 
 * Output
 * 1 10 2 3 4 6
 * 
 * Input
 * 20 12 4 319 21 31234 2 41 23 4
 * Insert 50 2
 * Insert 50 5
 * Delete 4
 * end
 * 
 * Output
 * 20 12 50 319 50 21 31234 2 41 23
 * 
 * 
 */