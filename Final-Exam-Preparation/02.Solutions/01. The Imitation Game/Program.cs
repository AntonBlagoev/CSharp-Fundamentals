using System;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] commands = input.Split('|');

                switch (commands[0])
                {
                    case "Move":
                        int numberOfLetters = int.Parse(commands[1]);
                        string substringToMove = message.Substring(0, numberOfLetters);
                        message = message.Remove(0, numberOfLetters);
                        message = message.Insert(message.Length, substringToMove);
                        break;

                    case "Insert":
                        int index = int.Parse(commands[1]);
                        string value = commands[2];
                        message = message.Insert(index, value);
                        break;

                    case "ChangeAll":
                        string substring = commands[1];
                        string replacement = commands[2];
                        message = message.Replace(substring, replacement);
                        break;
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
