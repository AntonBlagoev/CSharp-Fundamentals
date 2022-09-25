using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();

            foreach (var word in inputText)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(word);
                }
            }

            Console.WriteLine(sb);
        }
    }
}

/* Create a program that reads an array of strings. 
 * Each string is repeated N times, where N is the length of the string. Print the concatenated string.
 * 
 * Input
 * hi abc add
 * 
 * Output
 * hihiabcabcabcaddaddadd
 * 
 * Input
 * work
 * 
 * Output
 * workworkworkwork
 * 
 * Input
 * ball
 * 
 * Output
 * ballballballball
 * 
 */
