using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstNumber = Console.ReadLine().ToCharArray();
            int multiplier = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();

            int[] tempArr = new int[2];

            if (multiplier != 0)
            {
                for (int i = firstNumber.Length - 1; i >= 0; i--)
                {
                    int currentNumber = int.Parse(firstNumber[i].ToString());
                    int tempSum = (currentNumber * multiplier) + tempArr[0];

                    if (tempSum > 9)
                    {
                        tempArr[1] = tempSum % 10;
                        tempArr[0] = tempSum / 10;
                    }
                    else
                    {
                        tempArr[1] = tempSum;
                        tempArr[0] = 0;
                    }
                    result.Add(tempArr[1]);
                }

                if (tempArr[0] != 0)
                {
                    result.Add(tempArr[0]);
                }
            }
            else
            {
                result.Add(0);
            }

            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}

/* You are given two lines – the first one can be a really big number (0 to 1050). 
 * The second one will be a single-digit number (0 to 9). Your task is to display the product of these numbers. 
 * Note: do not use the BigInteger class.
 * 
 * Input
 * 23
 * 2
 * Output
 * 46
 * 
 * Input
 * 9999
 * 9
 * Output
 * 89991
 * 
 * Input
 * 923847238931983192462832102
 * 4
 * Output
 * 3695388955727932769851328408
 */
