using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Generate")
            {
                string[] commands = inputCommands.Split(">>>");

                switch (commands[0])
                {
                    case "Contains":
                        string substring = commands[1];
                        if (rawActivationKey.Contains(substring))
                        {
                            Console.WriteLine($"{rawActivationKey} contains {substring}");
                            continue;
                        }
                        Console.WriteLine("Substring not found!");
                        break;

                    case "Flip":
                        int startIndexToFlip = int.Parse(commands[2]);
                        int endIndexToFlip = int.Parse(commands[3]);
                        string tmpSubstring = rawActivationKey.Substring(startIndexToFlip, endIndexToFlip - startIndexToFlip);
                        if (commands[1] == "Upper")
                        {
                            tmpSubstring = tmpSubstring.ToUpper();
                        }
                        else
                        {
                            tmpSubstring = tmpSubstring.ToLower();
                        }
                        rawActivationKey = rawActivationKey.Remove(startIndexToFlip, endIndexToFlip - startIndexToFlip);
                        rawActivationKey = rawActivationKey.Insert(startIndexToFlip, tmpSubstring);
                        Console.WriteLine(rawActivationKey);
                        break;

                    case "Slice":
                        int startIndexToSlice = int.Parse(commands[1]);
                        int endIndexToSlice = int.Parse(commands[2]);
                        rawActivationKey = rawActivationKey.Remove(startIndexToSlice, endIndexToSlice - startIndexToSlice);
                        Console.WriteLine(rawActivationKey);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
