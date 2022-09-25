using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elementsList = Console.ReadLine().Split().ToList();
            elementsList.RemoveAll(n => n == "");

            int numberOfMoves = 0;

            while (true)
            {
                List<string> commands = Console.ReadLine().Split().ToList();
                commands.RemoveAll(n => n == "");

                if (commands[0] == "end")
                {
                    break;
                }

                int firstCommand = int.Parse(commands[0]);
                int secondCommand = int.Parse(commands[1]);
                int startIndex = Math.Min(firstCommand, secondCommand);
                int endIndex = Math.Max(firstCommand, secondCommand);

                numberOfMoves++;

                if (firstCommand >= 0 && firstCommand < elementsList.Count && secondCommand >= 0 && secondCommand < elementsList.Count && firstCommand != secondCommand)
                {
                    if (elementsList[firstCommand] == elementsList[secondCommand])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elementsList[firstCommand]}!");
                        elementsList.RemoveAt(endIndex);
                        elementsList.RemoveAt(startIndex);

                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }

                }

                else 
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    int insertIndex = elementsList.Count / 2;
                    elementsList.Insert(elementsList.Count / 2, "-" + numberOfMoves.ToString() + "a");
                    elementsList.Insert(elementsList.Count / 2, "-" + numberOfMoves.ToString() + "a");

                }


                if (elementsList.Count == 0)
                {
                    Console.WriteLine($"You have won in {numberOfMoves} turns!");
                    break;
                }

            }

            if (elementsList.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elementsList));
            }

        }
    }
}
