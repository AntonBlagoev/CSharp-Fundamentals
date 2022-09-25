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
                        break;

                    case "Reverse":  
                        string substring = commands[1]; 
                        if (!message.Contains(substring))
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                        int substringIndex = message.IndexOf(substring);

                        //message = message + string.Join("", stringToReverse.Reverse());
                        char[] reversedSubstring = substring.ToCharArray().Reverse().ToArray();
                        substring = string.Join("",reversedSubstring);

                        message = message.Remove(substringIndex, substring.Length); 
                        message = message.Insert(message.Length, substring);
                        break;

                    case "ChangeAll":
                        message = message.Replace(commands[1], commands[2]);
                        break;
                }
                Console.WriteLine(message);
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
