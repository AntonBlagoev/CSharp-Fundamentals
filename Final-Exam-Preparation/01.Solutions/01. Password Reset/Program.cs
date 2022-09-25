using System;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();
            

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Done")
            {
                string[] commands = inputCommands.Split();
                switch (commands[0])
                {
                    case "TakeOdd":
                        string tmpPassword = string.Empty;
                        for (int i = 1; i < password.Length; i = i + 2)
                        {
                            tmpPassword += password[i];
                        }
                        password = new string(tmpPassword);
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(commands[1]);
                        int length = int.Parse(commands[2]);
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string substring = commands[1];
                        string substitute = commands[2];
                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
