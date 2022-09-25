using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();

            int sumOfChars = 0;

            foreach (var currentChar in inputString)
            {
                if (currentChar > startChar && currentChar < endChar)
                {
                    sumOfChars += currentChar;
                }
            }
            Console.WriteLine(sumOfChars);
        }
    }
}
/* Create a program that prints a sum of all characters between two given characters (their ASCII code). 
 * On the first line, you will get a character. On the second line, you get another character. 
 * On the last line, you get a random string. Find all the characters between the two given and print their ASCII sum.
 * 
 * Input
 * .
 * @
 * dsg12gr5653feee5
 * Output
 * 363
 * 
 * Input
 * ?
 * E
 * @ABCEF
 * Output
 * 262

 * 
 */
