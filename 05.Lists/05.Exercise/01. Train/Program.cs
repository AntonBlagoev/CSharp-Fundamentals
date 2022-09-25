using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "end")
                {
                    break;
                }

                if (commands[0] == "Add")
                {
                    listOfWagons.Add(int.Parse(commands[1]));
                }
                else
                {
                    int passengers = int.Parse(commands[0]);

                    for (int i = 0; i < listOfWagons.Count; i++)
                    {
                        if (listOfWagons[i] + passengers <= maxCapacityOfWagon)
                        {
                            listOfWagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", listOfWagons));
        }
    }
}
/* On the first line, we will receive a list of wagons (integers). 
 * Each integer represents the number of passengers that are currently in each wagon of the passenger train. 
 * On the next line, you will receive the max capacity of a wagon, represented as a single integer. 
 * Until you receive the "end" command, you will be receiving two types of input:
 * •	Add {passengers} – add a wagon to the end of the train with the given number of passengers.
 * •	{passengers} – find a single wagon to fit all the incoming passengers (starting from the first wagon).
 * In the end, print the final state of the train (all the wagons separated by a space).
 * 
 * Input
 * 32 54 21 12 4 0 23
 * 75
 * Add 10
 * Add 0
 * 30
 * 10
 * 75
 * end
 * 
 * Output
 * 72 54 21 12 4 75 23 10 0
 * 
 * Input
 * 0 0 0 10 2 4
 * 10
 * Add 10
 * 10
 * 10
 * 10
 * 8
 * 6
 * end
 * 
 * Output
 * 10 10 10 10 10 10 10
 * 
 * 
 */
