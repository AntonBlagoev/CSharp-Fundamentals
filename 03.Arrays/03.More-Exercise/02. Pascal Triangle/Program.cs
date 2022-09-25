using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] previousRowArr = new int[1];

            for (int i = 0; i < n; i++)
            {
                int[] tmpArr = new int[i + 1];

                for (int j = 0; j < tmpArr.Length; j++)
                {
                    if (j == 0 || j == tmpArr.Length - 1)
                    {
                        tmpArr[j] = 1;
                    }
                    else
                    {
                        tmpArr[j] = previousRowArr[j] + previousRowArr[j - 1]; //Pascal formula
                    }

                    Console.Write($"{tmpArr[j]} ");
                }
                previousRowArr = tmpArr;
                Console.WriteLine();
            }


        }
    }
}
