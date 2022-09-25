using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int shotCount = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                int shotIndex = int.Parse(command);
                
                
                if (shotIndex >= 0 && shotIndex < inputArray.Length)
                {
                    int numberOfShotIndex = inputArray[shotIndex];
                    inputArray[shotIndex] = -1;
                    shotCount++;

                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        if (inputArray[i] > numberOfShotIndex && inputArray[i] != -1)
                        {
                            inputArray[i] -= numberOfShotIndex;
                        }
                        else if(inputArray[i] <= numberOfShotIndex && inputArray[i] != -1)
                        {
                            inputArray[i] += numberOfShotIndex;
                        }
                    }

                }
            }
            Console.Write($"Shot targets: {shotCount} -> ");
            Console.Write(string.Join(" ", inputArray));
        }
    }
}
