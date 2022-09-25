using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            string inputHouses = Console.ReadLine();
            List<string> housesList = inputHouses.Split(' ').ToList();

            int positionOfSanta = 0;

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(' ');

                switch (commands[0])
                {
                    case "Forward":
                        if ((positionOfSanta + int.Parse(commands[1])) < housesList.Count)
                        {
                            housesList.RemoveAt(positionOfSanta + int.Parse(commands[1]));
                            positionOfSanta += int.Parse(commands[1]);
                        }
                        break;

                    case "Back":
                        if ((positionOfSanta - int.Parse(commands[1])) >= 0)
                        {
                            housesList.RemoveAt(positionOfSanta - int.Parse(commands[1]));
                            positionOfSanta -= int.Parse(commands[1]);
                        }
                        break;

                    case "Gift":
                        if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < housesList.Count)
                        {
                            housesList.Insert(int.Parse(commands[1]), commands[2]);
                            positionOfSanta = int.Parse(commands[1]);
                        }
                        break;

                    case "Swap":
                        if (housesList.Contains(commands[1]) && housesList.Contains(commands[2]))
                        {
                            int indexOfFirst = housesList.IndexOf(commands[1]);
                            int indexOfSecond = housesList.IndexOf(commands[2]);

                            housesList[indexOfFirst] = commands[2];
                            housesList[indexOfSecond] = commands[1];
                        }
                        
                        break;
                }
            }

            Console.WriteLine($"Position: {positionOfSanta}");
            Console.Write(string.Join(", ", housesList));
        }
    }
}
