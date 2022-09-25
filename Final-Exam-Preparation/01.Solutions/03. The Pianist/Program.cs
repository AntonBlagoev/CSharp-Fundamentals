using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Composer> piecesDict = new Dictionary<string, Composer>();

            int nunberOfPieces = int.Parse(Console.ReadLine());

            for (int i = 0; i < nunberOfPieces; i++)
            {
                string[] currPiece = Console.ReadLine().Split('|');
                piecesDict.Add(currPiece[0], new Composer(currPiece[1], currPiece[2]));
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input.Split('|');

                switch (commands[0])
                {
                    case "Add":
                        if (!piecesDict.ContainsKey(commands[1]))
                        {
                            piecesDict.Add(commands[1], new Composer(commands[2], commands[3]));
                            Console.WriteLine($"{commands[1]} by {commands[2]} in {commands[3]} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{commands[1]} is already in the collection!");
                        }
                        break;

                    case "Remove":
                        if (piecesDict.ContainsKey(commands[1]))
                        {
                            piecesDict.Remove(commands[1]);
                            Console.WriteLine($"Successfully removed {commands[1]}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {commands[1]} does not exist in the collection.");
                        }
                        break;

                    case "ChangeKey":
                        if (piecesDict.ContainsKey(commands[1]))
                        {
                            piecesDict[commands[1]].Key = commands[2];
                            Console.WriteLine($"Changed the key of {commands[1]} to {commands[2]}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {commands[1]} does not exist in the collection.");
                        }
                        break;
                }
            }
            foreach (var piece in piecesDict)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.ComposerName}, Key: {piece.Value.Key}");
            }
        }
    }
}
class Composer
{
    public string ComposerName { get; set; }
    public string Key { get; set; }
    public Composer(string composer, string key)
    {
        ComposerName = composer;
        Key = key;
    }
}