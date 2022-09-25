using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxCount = int.MinValue;
            int currentCount = 0;
            int currentArrayIndex = int.MinValue;
            int maxArrayIndex = int.MinValue;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                
                if (inputArray[i] == inputArray[i + 1])
                {
                 currentCount++;
                 currentArrayIndex = i;

                    if (currentCount > maxCount)
                    {
                     maxCount = currentCount;
                     maxArrayIndex = currentArrayIndex;
                    }
                }
                else
                {
                    currentCount = 0;
                    currentArrayIndex = int.MinValue;
                }

            }

            for (int k = 0; k <= maxCount; k++)
            {
                Console.Write($"{inputArray[maxArrayIndex]} ");
            }


        }
    }
}
