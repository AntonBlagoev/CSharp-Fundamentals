using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputNumbers = input.Split(' ');
                long isBiggerNum = long.MinValue;
                long sumBiggerNum = 0;

                foreach (string num in inputNumbers)
                {
                    if (long.Parse(num) > isBiggerNum)
                    {
                        isBiggerNum = long.Parse(num);
                    }
                }

                while (isBiggerNum != 0)
                {
                    sumBiggerNum += isBiggerNum % 10;
                    isBiggerNum /= 10;
                }

                Console.WriteLine(Math.Abs(sumBiggerNum));
            }
        }
    }
}
