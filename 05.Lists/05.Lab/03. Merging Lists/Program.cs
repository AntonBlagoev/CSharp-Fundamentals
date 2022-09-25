using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mergedList = new List<int>();
            
            int maxCountList = Math.Max(firstNumbers.Count, secondNumbers.Count);
            
            for (int i = 0; i < maxCountList; i++)
            {
                if (firstNumbers.Count > i)
                {
                    mergedList.Add(firstNumbers[i]);
                }
                if(secondNumbers.Count > i)
                {
                    mergedList.Add(secondNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}

/* You are going to receive two lists of numbers. Create a list that contains the numbers from both of the lists. 
 * The first element should be from the first list, the second from the second list, and so on. 
 * If the length of the two lists is not equal, just add the remaining elements at the end of the list.
 *  
 * 
 * Input
 * 3 5 2 43 12 3 54 10 23
 * 76 5 34 2 4 12
 * 
 * Output
 * 3 76 5 5 2 34 43 2 12 4 3 12 54 10 23
 * 
 * Input
 * 76 5 34 2 4 12
 * 3 5 2 43 12 3 54 10 23
 * 
 * Output
 * 76 3 5 5 34 2 2 43 4 12 12 3 54 10 23
 * 
 * 
 */