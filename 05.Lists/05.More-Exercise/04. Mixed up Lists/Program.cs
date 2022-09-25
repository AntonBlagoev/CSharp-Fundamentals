using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();

            List<int> mixedList = new List<int>();
            int mixedListLenght = Math.Min(firstList.Count, secondList.Count) * 2;

            int countEven = 0;
            int countOdd = 0;

            for (int i = 0; i < mixedListLenght; i++)
            {
                if (i % 2 == 0)
                {
                    mixedList.Add(firstList[countEven]);
                    countEven++;
                }
                else
                {
                    mixedList.Add(secondList[countOdd]);
                    countOdd++;
                }
            }

            int firstRemainingElement = 0;
            int secondRemainingElement = 0;

            if (firstList.Count > secondList.Count)
            {
                firstRemainingElement = firstList[firstList.Count - 2];
                secondRemainingElement = firstList[firstList.Count - 1];
            }
            else
            {
                firstRemainingElement = secondList[secondList.Count - 2];
                secondRemainingElement = secondList[secondList.Count - 1];
            }

            int minRemainngElement = Math.Min(firstRemainingElement, secondRemainingElement);
            int maxRemainngElement = Math.Max(firstRemainingElement, secondRemainingElement);

            mixedList.Sort();

            Console.WriteLine(string.Join(" ", mixedList.FindAll(x => x > minRemainngElement && x < maxRemainngElement)));
        }
    }
}
/* Write a program that mixes up two lists by some rules. You will receive two lines of input, each one being a list of numbers. 
 * The mixing rules are:
 * •	Start from the beginning of the first list and the ending of the second.
 * •	Add element from the first and element from the second.
 * •	In the end, there will always be a list, in which there are 2 elements are remaining.
 * •	These elements will be the range of the elements you need to print.
 * •	Loop through the result list and take only the elements that fulfill the condition.
 * •	Print the elements ordered in ascending order and separated by a space.
 * 
 * Example
 * 
 * Input
 * 1 5 23 64 2 3 34 54 12
 * 43 23 12 31 54 51 92
 * 
 * Output
 * 23 23 31 34 43 51
 * 
 * Comment
 * After looping through the two of the arrays we get: 
 * 1 92 5 51 23 54 64 31 2 12 3 23 34 43
 * The constraints are 54 and 12 (so we take only the numbers between them): 51 23 31 23 34 43.
 * We print the result sorted.
 * 
 * Input
 * 87 30 65 23 39
 * 41 85 41 72 46 78 10
 * 
 * Output
 * 46 65 72 78
 * 
 */