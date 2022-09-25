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
                        string tmpMessage = message.Substring(0, int.Parse(commands[1]));
                        message = message.Remove(0, int.Parse(commands[1]));
                        message = message.Insert(message.Length, tmpMessage);
                        break;
                    case "Insert":
                        message = message.Insert(int.Parse(commands[1]), commands[2]);
                        break;
                    case "ChangeAll":
                        message = message.Replace(commands[1], commands[2]);
                        break;
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
