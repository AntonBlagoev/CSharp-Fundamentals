using System;

namespace _01.StringGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Done")
            {
                string[] commands = inputCommands.Split();

                switch (commands[0])
                {
                    case "Change":
                        inputString = inputString.Replace(commands[1], commands[2]);
                        Console.WriteLine(inputString);
                        break;

                    case "Includes":
                        if (inputString.Contains(commands[1]))
                        {
                            Console.WriteLine("True");
                            continue;
                        }
                        Console.WriteLine("False");
                        break;

                    case "End":
                        if (inputString.EndsWith(commands[1]))
                        {
                            Console.WriteLine("True");
                            continue;
                        }
                        Console.WriteLine("False");
                        break;

                    case "Uppercase":
                        inputString = inputString.ToUpper();
                        Console.WriteLine(inputString);
                        break;

                    case "FindIndex":
                        Console.WriteLine(inputString.IndexOf(commands[1]));
                        break;

                    case "Cut":
                        int startIndex = int.Parse(commands[1]);
                        int count = int.Parse(commands[2]);
                        Console.WriteLine(inputString.Substring(startIndex, count));
                        inputString = inputString.Remove(startIndex, count - 1);
                        break;
                }
            }
        }
    }
}
