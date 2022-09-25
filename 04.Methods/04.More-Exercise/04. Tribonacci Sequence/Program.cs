using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];

            TribonacciSequence(array);
            Console.Write(String.Join(" ", array));

        }

        public static int[] TribonacciSequence(int[] arr)
        {
            arr[0] = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                int sum = 0;
                int counter = 3;
                for (int j = i - 1; counter > 0; j--)
                {
                    if (j < 0)
                    {
                        break;
                    }
                    sum += arr[j];
                    counter--;
                }
                arr[i] = sum;
            }
            return arr;
        }
    }
}

/* In the "Tribonacci" sequence, every number is formed by the sum of the previous 3 numbers.
 * You are given a number num. Write a program that prints num numbers from the Tribonacci sequence, each on a new line, starting from 1. 
 * The input comes as a parameter named num. The value num will always be a positive integer.
 * 
 * Input
 * 4
 * 
 * Output
 * 1 1 2 4
 * 
 * Input
 * 8
 * 
 * Output
 * 1 1 2 4 7 13 24 44
 * 
 */
