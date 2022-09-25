using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder inputString = new StringBuilder();
            inputString.Append(Console.ReadLine());

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Travel")
            {
                string[] commands = inputCommands.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands[0] == "Add Stop")
                {
                    int insertIndex = int.Parse(commands[1]);
                    string insertString = commands[2];
                    if (insertIndex >= 0 && insertIndex < inputString.Length)
                    {
                        inputString.Insert(insertIndex, insertString);
                    }
                }
                else if (commands[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    int removeLenght = endIndex - startIndex + 1;
                    if (startIndex >= 0 && startIndex < inputString.Length && endIndex >= 0 && endIndex < inputString.Length && removeLenght > 0)
                    {
                        inputString.Remove(startIndex, removeLenght);
                    }
                }
                else if (commands[0] == "Switch")
                {
                    string oldIndex = commands[1];
                    string newIndex = commands[2];

                    if (inputString.ToString().Contains(oldIndex))
                    {
                        inputString.Replace(oldIndex, newIndex);
                    }
                }
                Console.WriteLine(inputString);
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {inputString}");
        }
    }
}