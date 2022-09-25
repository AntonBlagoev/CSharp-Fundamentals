using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] evenArray = new int[n]; //масив за четните i
            int[] oddArray = new int[n]; //масив за нечетните i

            for (int i = 0; i < n; i++)
            {
                int[] tmpArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    evenArray[i] = tmpArray[0];
                    oddArray[i] = tmpArray[1];
                }
                else
                {
                    evenArray[i] = tmpArray[1];
                    oddArray[i] = tmpArray[0];
                }
            }
            Console.WriteLine(string.Join(' ', evenArray));
            Console.WriteLine(string.Join(' ', oddArray));

            /*
            foreach (var item in evenArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
           
            foreach (var item in oddArray)
            {
                Console.Write($"{item} ");
            }
            */

        }
    }
}
