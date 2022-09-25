using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] commands = input.Split(":|:").ToArray();

                if (commands[0] == "InsertSpace")
                {
                    message = message.Insert(int.Parse(commands[1]), " ");
                }
                else if (commands[0] == "Reverse")
                {
                    string stringToReverse = commands[1];
                    if (message.Contains(stringToReverse))
                    {
                        int indexOfString = message.IndexOf(stringToReverse);
                        message = message.Remove(indexOfString, stringToReverse.Length);
                        message = message + string.Join("", stringToReverse.Reverse()); // short version
                        //message = $"{message}{string.Join("", stringToReverse.Reverse())}";

                        //char[] charArr = stringToReverse.ToCharArray();
                        //Array.Reverse(charArr);
                        //string reversedString = string.Join("", charArr);
                        //message += reversedString;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (commands[0] == "ChangeAll")
                {
                    if (message.Contains(commands[1]))
                    {
                        message = message.Replace(commands[1], commands[2]);
                    }
                }
                Console.WriteLine(message);
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
