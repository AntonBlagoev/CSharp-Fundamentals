using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] tmpArrLeft = new int[inputArr.Length / 4];
            int[] tmpArrRight = new int[inputArr.Length / 4];
            int[] tmpArrMiddle = new int[inputArr.Length / 2];
            int[] tmpArrTop = new int[inputArr.Length / 2];

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (i + 1 <= tmpArrLeft.Length)
                {
                    tmpArrLeft[i] = inputArr[i];
                }
                else if (i + 1 > tmpArrLeft.Length + tmpArrMiddle.Length)
                {
                    tmpArrRight[i - tmpArrLeft.Length - tmpArrMiddle.Length] = inputArr[i];
                }
                else
                {
                    tmpArrMiddle[i - tmpArrLeft.Length] = inputArr[i];
                }
            }

            Array.Reverse(tmpArrLeft);
            Array.Reverse(tmpArrRight);

            for (int i = 0; i < tmpArrTop.Length; i++)
            {
                if (i + 1 <= tmpArrTop.Length / 2)
                {
                    tmpArrTop[i] = tmpArrLeft[i];
                }
                else
                {
                    tmpArrTop[i] = tmpArrRight[i - tmpArrRight.Length];
                }
            }

            int sum = 0;

            for (int i = 0; i < tmpArrTop.Length; i++)
            {
                sum = tmpArrTop[i] + tmpArrMiddle[i];
                Console.Write($"{sum} ");

            }
        }
    }
}
