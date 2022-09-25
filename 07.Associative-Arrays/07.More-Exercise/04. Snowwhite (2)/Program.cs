using System;
using System.Collections.Generic;
using System.Linq;


namespace _04._Snowwhite__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfList = new List<Dwarf>();
            int hatColorCount = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = input.Split();
                string dwarfName = tokens[0];
                string dwarfHatColor = tokens[2];
                int dwarfPhysics = int.Parse(tokens[4]);

                if (!(dwarfList.Any(x => x.Name == dwarfName && x.HatColor == dwarfHatColor)))
                {
                    dwarfList.Add(new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics, hatColorCount));
                    
                }
                else if (dwarfList.Any(x => x.Name == dwarfName && x.HatColor == dwarfHatColor && x.Physics < dwarfPhysics))
                {
                    int currIndex = dwarfList.FindIndex(x => x.Name == dwarfName && x.HatColor == dwarfHatColor && x.Physics < dwarfPhysics);
                    dwarfList.Insert(currIndex, new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics, hatColorCount));
                    dwarfList.RemoveAt(currIndex + 1);
                }

                int count = dwarfList.Where(x => x.HatColor == dwarfHatColor).Count() + 1;
                foreach (var item in dwarfList.Where(x => x.HatColor == dwarfHatColor))
                {
                    item.HatColorCount = count;
                }
            }
            

            foreach (var dwarf in dwarfList
                .OrderByDescending(x => x.Physics)
                .ThenByDescending(x => x.HatColorCount)
                )
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
    class Dwarf
    {
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }
        public int HatColorCount { get; set; }
        public Dwarf(string name, string hat, int physics, int hatColorCount)
        {
            Name = name;
            HatColor = hat;
            Physics = physics;
            HatColorCount = hatColorCount;
        }
    }
}
/* Snow White loves her dwarfs, but there are so many and she doesn't know how to order them. 
 * Does she order them by name? Or by the color of their hat? Or by physics? She can't decide, 
 * so it's up to you to write a program that does it for her.
 * You will be receiving several input lines which contain data about dwarfs in the following format:
 * "{dwarfName} <:> {dwarfHatColor} <:> {dwarfPhysics}"
 * The dwarfName and the dwarfHatColor are strings. The dwarfPhysics is an integer.
 * You must store the dwarfs in your program. There are several rules though:
 * •	If 2 dwarfs have the same name but different colors, they should be considered different dwarfs, and you should store both of them.
 * •	If 2 dwarfs have the same name and the same color, store the one with the higher physics.
 * When you receive the command "Once upon a time", the input ends. 
 * You must order the dwarfs by physics in descending order and then by the total count of dwarfs with the same hat color in descending order.
 * 
 * Then you must print them all. 
 * 
 * Input
 * •	The input will consist of several input lines, containing dwarf data in the format, specified above.
 * •	The input ends when you receive the command "Once upon a time". 
 * 
 * Output
 * •	As output, you must print the dwarfs, ordered in the way, specified above.
 * •	The output format is: "({hatColor}) {name} <-> {physics}"
 * 
 * Constraints
 * •	The dwarfName will be a string that may contain any ASCII character except ' ' (space), '<', ':', ' >'.
 * •	The dwarfHatColor will be a string that may contain any ASCII character except  ' ' (space), '<', ':', '>'.
 * •	The dwarfPhysics will be an integer in the range [0… 231 – 1].
 * •	There will be no invalid input lines.
 * •	If all sorting criteria fail, the order should be by order of input.
 * •	Allowed working time / memory: 100ms / 16MB. * 
 * 
 * INPUT
 * Peter <:> Red <:> 2000
 * Tony <:> Blue <:> 1000
 * George <:> Green <:> 1000
 * Sam <:> Yellow <:> 4500
 * John <:> Black <:> 1000
 * Once upon a time
 * 
 * OUTPUT
 * (Yellow) Sam <-> 4500
 * (Red) Peter <-> 2000
 * (Blue) Tony <-> 1000
 * (Green) George <-> 1000
 * (Black) John <-> 1000 
 * 
 * INPUT
 * Peter <:> Red <:> 5000
 * Peter <:> Blue <:> 10000
 * Peter <:> Red <:> 10000
 * George <:> Blue <:> 10000
 * Once upon a time
 * 
 * OUTPUT * 
 * (Blue) Peter <-> 10000
 * (Blue) George <-> 10000
 * (Red) Peter <-> 10000 
 * 
 * 
 */