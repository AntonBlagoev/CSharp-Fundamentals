using System;
using System.Collections.Generic;

namespace _03._The_Pianist___KeyVauePair
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<string, string>> piecesDict = new Dictionary<string, KeyValuePair<string, string>>();

            int nunberOfPieces = int.Parse(Console.ReadLine());

            for (int i = 0; i < nunberOfPieces; i++)
            {
                string[] currPiece = Console.ReadLine().Split('|');
                piecesDict.Add(currPiece[0], new KeyValuePair<string, string>(currPiece[1], currPiece[2]));

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
                            piecesDict.Add(commands[1], new KeyValuePair<string, string>(commands[2], commands[3]));
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
                            string composer = piecesDict[commands[1]].Key;
                            piecesDict.Remove(commands[1]);
                            piecesDict.Add(commands[1], new KeyValuePair<string, string>(composer, commands[2]));
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
                Console.WriteLine($"{piece.Key} -> Composer: {piecesDict[piece.Key].Key}, Key: {piecesDict[piece.Key].Value}");
            }
        }
    }
}
