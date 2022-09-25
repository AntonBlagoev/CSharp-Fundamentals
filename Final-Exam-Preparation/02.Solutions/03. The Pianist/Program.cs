using System;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Piece> piecesDict = new Dictionary<string, Piece>();

            int numberOfPieces = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] inputPieces = Console.ReadLine().Split('|');
                piecesDict.Add(inputPieces[0], new Piece(inputPieces[1], inputPieces[2]));
            }
            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Stop")
            {
                string[] commands = inputCommands.Split('|');

                switch (commands[0])
                {
                    case "Add":
                        Add(commands[1], commands[2], commands[3], piecesDict);
                        break;
                    case "Remove":
                        Remove(commands[1], piecesDict);
                        break;
                    case "ChangeKey":
                        ChangeKey(commands[1], commands[2], piecesDict);
                        break;
                }
            }

            foreach (var piece in piecesDict)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
            }
        }

        static void Add(string piece, string composer, string key, Dictionary<string, Piece> piecesDict)
        {
            if (piecesDict.ContainsKey(piece))
            {
                Console.WriteLine($"{piece} is already in the collection!");
                return;
            }
            piecesDict.Add(piece, new Piece(composer, key));
            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
        }
        static void Remove(string piece, Dictionary<string, Piece> piecesDict)
        {
            if (piecesDict.ContainsKey(piece))
            {
                piecesDict.Remove(piece);
                Console.WriteLine($"Successfully removed {piece}!");
                return;
            }
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
        static void ChangeKey(string piece, string newKey, Dictionary<string, Piece> piecesDict)
        {
            if (piecesDict.ContainsKey(piece))
            {
                piecesDict[piece].Key = newKey;
                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                return;
            }
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }

    }
}

class Piece
{
    public string Composer { get; set; }
    public string Key { get; set; }
    public Piece(string composer, string key)
    {
        Composer = composer;
        Key = key;
    }
}
