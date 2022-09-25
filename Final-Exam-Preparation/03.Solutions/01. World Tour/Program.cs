using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Travel")
            {
                string[] commands = inputCommands.Split(':');

                switch (commands[0])
                {
                    case "Add Stop":
                        int index = int.Parse(commands[1]);
                        string stringToAdd = commands[2];
                        if (index >=0 && index < inputString.Length)
                        {
                            inputString = inputString.Insert(index, stringToAdd);
                        }
                        break;

                    case "Remove Stop":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        if (startIndex >=0 && startIndex < inputString.Length && endIndex >=0 && endIndex < inputString.Length && startIndex <= endIndex)
                        {
                            inputString = inputString.Remove(startIndex, endIndex - startIndex + 1);
                        }
                        break;

                    case "Switch":
                        string oldString = commands[1];
                        string newString = commands[2];
                        if (inputString.Contains(oldString))
                        {
                            inputString = inputString.Replace(oldString, newString);
                        }

                        break;
                }
                Console.WriteLine(inputString);
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {inputString}");
        }
    }
}
