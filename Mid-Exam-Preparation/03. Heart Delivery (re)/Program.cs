using System;
using System.Collections.Generic;
using System.Linq;


namespace _03._Heart_Delivery__re_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int currentPosition = 0;

            while (true)
            {

                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "Love!")
                {
                    break;
                }

                int jump = currentPosition + int.Parse(commands[1]);

                if (jump > inputList.Count - 1)
                {
                    currentPosition = 0;
                    jump = 0;
                }

                if (inputList[jump] == 0)
                {
                    Console.WriteLine($"Place {jump} already had Valentine's day.");
                    currentPosition = jump;

                }
                else if (inputList[jump] == 2)
                {
                    Console.WriteLine($"Place {jump} has Valentine's day.");
                    currentPosition = jump;
                    inputList[jump] = 0;
                }

                else
                {

                    inputList[jump] -= 2;
                    currentPosition = jump;
                }






            }

            int sum = inputList.Sum();
            Console.WriteLine($"Cupid's last position was {currentPosition}.");


            if (sum == 0)
            {
                Console.WriteLine("Mission was successful.");
            }

            else
            {
                inputList.RemoveAll(x => x == 0);
                int houseCount = inputList.Count;
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }

        }
    }
}
