using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songsList = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] inputArr = Console.ReadLine().Split('_');

                Song song = new Song();

                song.TypeLIst = inputArr[0];
                song.Name = inputArr[1];
                song.Time = inputArr[2];

                songsList.Add(song);
            }

            string printCommand = Console.ReadLine();

            if (printCommand == "all")
            {
                foreach (var song in songsList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songsList)
                {
                    if (printCommand == song.TypeLIst)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public string TypeLIst { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}

/* Define a class called Song that will hold the following information about some songs:
 * •	Type List
 * •	Name
 * •	Time
 * Input / Constraints
 * •	On the first line, you will receive the number of songs - N.
 * •	On the next N lines, you will be receiving data in the following format:  "{typeList}_{name}_{time}".
 * •	On the last line, you will receive Type List or "all".
 * Output
 * If you receive Type List as an input on the last line, print out only the names of the songs, which are from that Type List. 
 * If you receive the "all" command, print out the names of all the songs.
 * 
 * INPUT
 * 3
 * favourite_DownTown_3:14
 * favourite_Kiss_4:16
 * favourite_Smooth Criminal_4:01
 * favourite
 * 
 * OUTPUT
 * DownTown
 * Kiss
 * Smooth Criminal
 * 
 * INPUT
 * 4
 * favourite_DownTown_3:14
 * listenLater_Andalouse_3:24
 * favourite_In To The Night_3:58
 * favourite_Live It Up_3:48
 * listenLater
 * 
 * OUTPUT
 * Andalouse
 * 
 * INPUT
 * 2
 * like_Replay_3:15
 * ban_Photoshop_3:48
 * all
 * 
 * OUTPUT
 * Replay
 * Photoshop
 * 
 * 
 * 
 */