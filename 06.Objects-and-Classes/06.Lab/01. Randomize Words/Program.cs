using System;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int newRandomIndex = rnd.Next(0, words.Length);
                string tmpWord = words[i];
                words[i] = words[newRandomIndex];
                words[newRandomIndex] = tmpWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}

/* You will be given a string that will contain words separated by a single space. Randomize their order and print each word on a new line.
 * 
 * Input
 * Welcome to SoftUni and have fun learning programming
 * 
 * Output
 * learning
 * Welcome
 * SoftUni
 * and
 * fun
 * programming
 * have
 * to
 * 
 * Comments
 * The order of the words in the output will be different after each program execution.
 * 
 */
