using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            inputList.Sort();
            inputList.Reverse();

            double sumOfList = inputList.Sum();
            double averageValue = sumOfList / inputList.Count;

            List<int> newList = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                if (inputList[i] > averageValue)
                {
                    newList.Add(inputList[i]);
                }
                else
                {
                    break;
                }
            }
            


            if (sumOfList / inputList.Count == inputList[0])
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", newList));
            }

            



        }
    }
}
