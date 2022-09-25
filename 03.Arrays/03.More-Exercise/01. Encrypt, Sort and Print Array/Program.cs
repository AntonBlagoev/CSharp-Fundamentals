using System;
using System.Linq;
using System.Collections;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            int[] intArr = new int[numberOfStrings];
            
            for (int i = 0; i < numberOfStrings; i++)
            {
                string inputWord = Console.ReadLine();
                char[] charArr = inputWord.ToCharArray();
                 
                int sum = 0;

                for (int j = 0; j < inputWord.Length; j++)
                {
                    
                    switch (charArr[j])
                    {
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            sum += charArr[j] * inputWord.Length;
                            break;
                        default:
                            sum += charArr[j] / inputWord.Length;
                            break;
                    }
                }
                intArr[i] = sum;
            }

            Array.Sort(intArr);
            Console.WriteLine();

            foreach (var item in intArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
