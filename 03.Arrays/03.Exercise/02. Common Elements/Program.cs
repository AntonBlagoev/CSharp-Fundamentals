using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split().ToArray();
            string[] secondtArr = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < secondtArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (firstArr[j] == secondtArr[i])
                    {
                        Console.Write($"{firstArr[j]} ");
                        break;
                    }
                }
            }

            
        }
    }
}
