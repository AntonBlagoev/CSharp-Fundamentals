using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] tmpArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    tmpArr[i] = 1;
                }
                else
                {
                    tmpArr[i] = tmpArr[i - 1] + tmpArr[i - 2];
                }
            }
            Console.WriteLine(tmpArr[n - 1]);

        }
    }
}
