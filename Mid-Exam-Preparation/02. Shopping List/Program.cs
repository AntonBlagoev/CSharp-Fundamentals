using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            //List<int> stateOfLift = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                if (waitingPeople >= 4)
                {
                    waitingPeople += lift[i];
                    lift[i] = 4;
                    waitingPeople -= 4;
                }
                else if (waitingPeople > 0)
                {
                    waitingPeople += lift[i];
                    if (waitingPeople >= 4)
                    {
                        lift[i] = 4;
                        waitingPeople -= 4;
                    }
                    else
                    {
                        lift[i] = waitingPeople;
                        waitingPeople -= waitingPeople;
                    }
                }
                else
                {
                    break;
                }
            }

            if (waitingPeople == 0 && lift.Length * 4 > lift.Sum())
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (waitingPeople > 0 && lift.Length * 4 == lift.Sum())
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (waitingPeople == 0 && lift.Length * 4 == lift.Sum())
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
