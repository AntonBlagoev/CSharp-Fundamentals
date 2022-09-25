using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "End")
                {
                    break;
                }

                if (commands[0] == "Shoot")
                {
                    int index = int.Parse(commands[1]);
                    int power = int.Parse(commands[2]);
                    Shot(targets, index, power);
                }

                else if (commands[0] == "Add")
                {
                    int index = int.Parse(commands[1]);
                    int value = int.Parse(commands[2]);
                    Add(targets, index, value);
                }

                else if (commands[0] == "Strike")
                {
                    int index = int.Parse(commands[1]);
                    int radius = int.Parse(commands[2]);
                    Strike(targets, index, radius);
                }
            }

            Console.WriteLine(string.Join("|", targets));

        }

        static void Strike(List<int> targets, int index, int radius)
        {
            if ((index - radius) < 0 || (index + radius) > targets.Count - 1)
            {
                Console.WriteLine("Strike missed!");
                return;
            }
            targets.RemoveRange(index - radius, (radius * 2) + 1);
        }

        static void Add(List<int> targets, int index, int value)
        {
            if (index < 0 || index > targets.Count - 1)
            {
                Console.WriteLine("Invalid placement!");
                return;
            }
            targets.Insert(index, value);
            
        }

        static void Shot(List<int> targets, int index, int power)
        {
            if (index < 0 || index > targets.Count - 1)
            {
                return;
            }

            targets[index] -= power;
            if (targets[index] <= 0)
            {
                targets.RemoveAt(index);
            }
            
        }
    }
}
