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
                        if (rawActivationKey.Contains(commands[1]))
                        {
                            Console.WriteLine($"{rawActivationKey} contains {commands[1]}");
                            continue;
                        }
                        Console.WriteLine("Substring not found!");
                        break;

                    case "Flip":

                        string upperOrLower = commands[1];
                        int startIndex = int.Parse(commands[2]);
                        int endIndex = int.Parse(commands[3]);
                        if (commands[1] == "Upper")
                        {
                            string tmpSubstring = rawActivationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
                            rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                            rawActivationKey = rawActivationKey.Insert(startIndex, tmpSubstring);
                        }
                        else
                        {
                            string tmpSubstring = rawActivationKey.Substring(startIndex, endIndex - startIndex).ToLower();
                            rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                            rawActivationKey = rawActivationKey.Insert(startIndex, tmpSubstring);
                        }
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
