using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            
            for (int i = 1; i < inputString.Length; i++)
            {
                if (inputString[i] == inputString[i - 1])
                {
                    inputString = inputString.Remove(i, 1);
                    i--;
                }
            }

            Console.WriteLine(inputString);
        }
    }
}
/* Create a program that reads a string from the console and replaces any sequence of the same letter with a single corresponding letter.
 * 
 * Input
 * aaaaabbbbbcdddeeeedssaa
 * Output
 * abcdedsa
 * 
 * Input
 * qqqwerqwecccwd
 * Output
 * qwerqwecwd
 * 
 * 
 */