using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOfEachArray = 0;
            
            for (int index = 0; index < arrayOne.Length; index++)
            {
                if (arrayOne[index] != arrayTwo[index])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    break;
                }
                else
                {
                    sumOfEachArray += arrayOne[index];
                }
                if (index == arrayOne.Length - 1)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sumOfEachArray}");
                }
            }

            
        }
    }
}
