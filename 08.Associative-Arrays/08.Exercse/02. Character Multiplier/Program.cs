using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split();

            Console.WriteLine(CharMultiplier(inputStrings[0], inputStrings[1]));
        }

        static int CharMultiplier(string firstString, string secondString)
        {
            int sum = 0;

            int minLenght = Math.Min(firstString.Length, secondString.Length);
            int maxLenght = Math.Max(firstString.Length, secondString.Length);

            string maxLenghtString = firstString.Length > secondString.Length ? firstString : secondString;

            for (int i = 0; i < minLenght; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            for (int i = minLenght; i < maxLenght; i++)
            {
                sum += maxLenghtString[i];
            }

            return sum;
        }
    }
}

/* Create a method that takes two strings as arguments and returns the sum of their character codes multiplied. 
 * Multiply str1[0] with str2[0] and add to the total sum. Then continue with the next two characters. 
 * If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.
 * 
 * Input
 * Peter George
 * Output
 * 52114
 * 
 * Input
 * 123 522
 * Output
 * 7647
 * 
 * Input
 * a aaaa
 * Output
 * 9700
 * 
 * 
 */
