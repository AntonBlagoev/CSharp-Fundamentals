using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());

            PrintMatrixNxN(inputN);
        }

        static void PrintMatrixNxN(int inputN)
        {
            for (int i = 0; i < inputN; i++)
            {
                for (int j = 0; j < inputN; j++)
                {
                    Console.Write($"{inputN} ");
                }
                Console.WriteLine();
            }
        }
    }
}


/* Create a method that receives a single integer n and prints an NxN matrix using this number as a filler.
 * 
 * Input
 * 3
 * Output
 * 3 3 3
 * 3 3 3
 * 3 3 3
 * 
 * Input
 * 7
 * Output
 * 7 7 7 7 7 7 7
 * 7 7 7 7 7 7 7
 * 7 7 7 7 7 7 7
 * 7 7 7 7 7 7 7
 * 7 7 7 7 7 7 7
 * 7 7 7 7 7 7 7
 * 7 7 7 7 7 7 7 
 * 
 * Input
 * 2
 * Output
 * 2 2
 * 2 2
 * 
 */