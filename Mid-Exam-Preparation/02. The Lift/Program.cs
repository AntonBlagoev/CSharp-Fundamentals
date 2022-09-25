using System;
using System.Linq;



namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            //List<int> stateOfLift = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] stateOfLift = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < stateOfLift.Length; i++)
            {
                if (waitingPeople >= 4)
                {
                    waitingPeople += stateOfLift[i];
                    stateOfLift[i] = 4;
                    waitingPeople -= 4;
                }
                else if (waitingPeople > 0)
                {
                    waitingPeople += stateOfLift[i];
                    if (waitingPeople >= 4)
                    {
                        stateOfLift[i] = 4;
                        waitingPeople -= 4;
                    }
                    else
                    {
                        stateOfLift[i] = waitingPeople;
                        waitingPeople -= waitingPeople;
                    }
                }
                else
                {
                    break;
                }
            }



            if (waitingPeople == 0 && stateOfLift.Length * 4 > stateOfLift.Sum())
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", stateOfLift));
            }
            else if (waitingPeople > 0 && stateOfLift.Length * 4 == stateOfLift.Sum())
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", stateOfLift));
            }
            else if (waitingPeople == 0 && stateOfLift.Length * 4 == stateOfLift.Sum())
            {
                Console.WriteLine(string.Join(" ", stateOfLift));
            }
            else
            {
                Console.WriteLine(string.Join(" ", stateOfLift));
            }
        }
    }
}
