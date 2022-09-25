using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            VowelsCount(inputText);
        }

        static void VowelsCount(string inputText)
        {
            //Console.WriteLine(inputText.Count(vowles => "aeiou".Contains(vowles))); // short version
            
            int count = 0;
            foreach (char vowle in inputText)
            {
                if ("aeiou".Contains(vowle))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            /*
            int vowels = 0;

            for (int i = 0; i < inputText.Length; i++)
            {
                switch (inputText[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowels++;
                        break;
                    default:
                        break;
                }
            
            string count = vowels.ToString();
            Console.WriteLine(count);
            */
        }
    }
}

/* Create a method that receives a single string and prints out the number of vowels contained in it.
 * 
 * Input
 * SoftUni
 * Output
 * 3
 * 
 * Input
 * Cats
 * Output
 * 1
 * 
 * Input
 * JS
 * Output
 * 0
 * 
 */