using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Reveal")
            {
                string[] commands = inputCommands.Split(":|:");

                switch (commands[0])
                {
                    case "InsertSpace":
                        message = message.Insert(int.Parse(commands[1]), " ");
                        Console.WriteLine(message);
                        break;

                    case "Reverse":
                        string substring = commands[1];
                        if (message.Contains(substring))
                        {
                            int substringIndex = message.IndexOf(substring);
                            message = message.Remove(substringIndex, substring.Length);
                            substring = new string (substring.ToCharArray().Reverse().ToArray());
                            message = message.Insert(message.Length, substring);
                            Console.WriteLine(message);
                            continue;
                        }
                        Console.WriteLine("error");
                        break;

                    case "ChangeAll":
                        message = message.Replace(commands[1], commands[2]);
                        Console.WriteLine(message);
                        break;
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
