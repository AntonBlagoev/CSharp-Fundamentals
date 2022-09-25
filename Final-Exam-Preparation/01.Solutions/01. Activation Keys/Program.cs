using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] commands = input.Split(">>>");

                switch (commands[0])
                {
                    case "Contains":
                        if (rawActivationKey.Contains(commands[1]))
                        {
                            Console.WriteLine($"{rawActivationKey} contains {commands[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Flip":
                        int starIndexFlip = int.Parse(commands[2]);
                        int endIndexFlip = int.Parse(commands[3]);
                        int lenght = endIndexFlip - starIndexFlip;
                        string oldSubstring = rawActivationKey.Substring(starIndexFlip, lenght);
                        string newSubstring = oldSubstring.ToLower();

                        if (commands[1] == "Upper")
                        {
                            oldSubstring = oldSubstring.ToUpper();
                        }
                        rawActivationKey = rawActivationKey.Replace(oldSubstring, newSubstring);

                        //rawActivationKey = rawActivationKey.Remove(starIndexFlip, lenght);
                        //rawActivationKey = rawActivationKey.Insert(starIndexFlip, substring);

                        Console.WriteLine(rawActivationKey);
                        break;

                    case "Slice":
                        int starIndexSlice = int.Parse(commands[1]);
                        int endIndexSlice = int.Parse(commands[2]);
                        int lenghtSlice = endIndexSlice - starIndexSlice;
                        rawActivationKey = rawActivationKey.Remove(starIndexSlice, lenghtSlice);
                        Console.WriteLine(rawActivationKey);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
