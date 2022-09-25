using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participantsDict = new Dictionary<string, int>();
            Dictionary<string, int> availableSongsDict = new Dictionary<string, int>();
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

            string[] firstLineInput = Console.ReadLine().Split(", ");
            foreach (var participant in firstLineInput)
            {
                participantsDict.Add(participant, 0);
            }

            string[] secondLineInput = Console.ReadLine().Split(", ");
            foreach (var song in secondLineInput)
            {
                availableSongsDict.Add(song, 0);
            }

            string thirdLineInput = string.Empty;
            while ((thirdLineInput = Console.ReadLine()) != "dawn")
            {
                string[] stage = thirdLineInput.Split(", ");
                string participant = stage[0];
                string song = stage[1];
                string award = stage[2];

                if (participantsDict.ContainsKey(participant) && availableSongsDict.ContainsKey(song))
                {
                    if (players.ContainsKey(participant) && !players.Values.Any(x => x.Contains(award)))
                    {
                        players[participant].Add(award);
                    }
                    else if (!players.ContainsKey(participant))
                    {
                        players.Add(participant, new List<string>());
                        players[participant].Add(award);
                    }
                }
            }
            if (players.Count > 0)
            {
                foreach (var player in players
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key)
                    )
                {
                    Console.WriteLine($"{player.Key}: {player.Value.Count} awards");

                    foreach (var item in player.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{item}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }




        }
    }
}
