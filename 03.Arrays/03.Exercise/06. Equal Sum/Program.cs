using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = false;
            for (int i = 0; i < inputArray.Length; i++)
            {
                int sumRights = 0;
                int sumLefts = 0;

                for (int r = i + 1; r < inputArray.Length; r++)
                {
                    sumRights += inputArray[r];
                }
                for (int l = 0; l < i; l++)
                {
                    sumLefts += inputArray[l];
                }
                if (sumRights == sumLefts)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                    break;
                }
            }

            if (isEqual != true)
            {
                Console.WriteLine("no");
            }



        }
    }
}
