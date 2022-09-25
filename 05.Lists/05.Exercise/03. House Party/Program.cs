using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            var guestList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (guestList.Contains(commands[0]))
                {
                    if (commands[2] == "going!")
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Remove(commands[0]);
                    }
                }
                else
                {
                    if (commands[2] == "going!")
                    {
                        guestList.Add(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }
            }
            foreach (var guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}

/* Create a program that keeps track of the guests that are going to a house party. 
 * On the first line, of input you are going to receive the number of commands that will follow.
 * On the next lines, you are going to receive some of the following:  "{name} is going!"
 * •	You have to add the person, if they are not on the guestlist already.
 * •	If the person is on the list print the following to the console: "{name} is already in the list!"
 * "{name} is not going!"
 * •	You have to remove the person, if they are on the list. 
 * * •	If not, print out: "{name} is not in the list!"
 * Finally, print all of the guests, each on a new line.
 * 
 * Examples
 * 
 * Input
 * 4
 * Allie is going!
 * George is going!
 * John is not going!
 * George is not going!
 * 
 * Output
 * John is not in the list!
 * Allie
 * 
 * Input
 * 5
 * Tom is going!
 * Annie is going!
 * Tom is going!
 * Garry is going!
 * Jerry is going!
 * 
 * Output
 * Tom is already in the list!
 * Tom
 * Annie
 * Garry
 * Jerry
 * 
 */