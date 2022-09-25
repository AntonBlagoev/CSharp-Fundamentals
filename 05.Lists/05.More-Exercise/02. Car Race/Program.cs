using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> timeList = Console.ReadLine().Split().Select(int.Parse).ToList();

            double timeOfLeftRacer = 0.0;
            double timeOfRightRacer = 0.0;

            for (int i = 0; i < timeList.Count / 2; i++)
            {
                if (timeList[i] == 0)
                {
                    timeOfLeftRacer *= 0.8;
                }
                else
                {
                    timeOfLeftRacer += timeList[i];
                }
            }

            for (int i = timeList.Count - 1; i > timeList.Count / 2; i--)
            {
                if (timeList[i] == 0)
                {
                    timeOfRightRacer *= 0.8;
                }
                else
                {
                    timeOfRightRacer += timeList[i];
                }
            }

            if (timeOfLeftRacer < timeOfRightRacer)
            {
                Console.WriteLine($"The winner is left with total time: {timeOfLeftRacer}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeOfRightRacer}");

            }
        }
    }
}
/* Write a program to calculate the winner of a car race. 
 * You will receive an array of numbers. 
 * Each element of the array represents the time needed to pass through that step (the index). 
 * There are going to be two cars. One of them starts from the left side and the other one starts from the right side. 
 * The middle index of the array is the finish line. The number of elements in the array will always be odd. 
 * Calculate the total time for each racer to reach the finish, which is the middle of the array, 
 * and print the winner with his total time (the racer with less time). 
 * If you have a zero in the array, you have to reduce the time of the racer that reached it by 20% (from his current time).
 * 
 * Print the result in the following format "The winner is {left/right} with total time: {total time}".
 * 
 * Example
 * 
 * Input
 * 29 13 9 0 13 0 21 0 14 82 12
 * 
 * Output
 * The winner is left with total time: 53.8
 * 
 * Comment
 * The time of the left racer is (29 + 13 + 9) * 0.8 (because of the zero) + 13 = 53.8
 * The time of the right racer is (82 + 12 + 14) * 0.8 + 21 = 107.4
 * The winner is the left racer, so we print it
 * 
 * Input
 * 26 46 31 43 1 23 44
 * 
 * Output
 * The winner is right with total time: 68
 *  
 */