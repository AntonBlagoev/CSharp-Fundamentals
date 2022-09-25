using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                PrintTriangle(1, i);
            }
            for (int i = input - 1; i >= 1; i--)
            {
                PrintTriangle(1, i);
            }
        }

        static void PrintTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

        }

    }
}

/* Create a method for printing triangles as shown below:
 * 
 * Input
 * 3
 * Output
 * 1
 * 1 2
 * 1 2 3
 * 1 2
 * 1
 * 
 * Input
 * 2
 * Output
 * 1
 * 1 2
 * 1
 * 
 */