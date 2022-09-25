using System;
using System.Text;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string inputText = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string asterisk = new string('*', bannedWords[i].Length);

                inputText = inputText.Replace(bannedWords[i], asterisk);
            }

            Console.WriteLine(inputText);

        }
    }
}

/* Create a program that takes a text and a string of banned words. 
 * All words included in the ban list should be replaced with a string of asterisks '*', whose length must be equal to the word's length. 
 * The entries in the ban list will be separated by a comma and space ", ". 
 * The ban list should be entered on the first input line and the text on the second input line. 
 *  
 * INPUT
 * Linux, Windows
 * It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client
 * 
 * OUTPUT
 * It is not *****, it is GNU/*****. ***** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/*****! Sincerely, a ******* client
 * 
 * INPUT
 * von Richthofen, German, 80 air
 * Manfred Albrecht Freiherr von Richthofen, known in English as Baron von Richthofen was a fighter pilot with the German Air Force during World War I. He is considered the ace-of-aces of the war, being officially credited with 80 air combat victories.
 * 
 * OUTPUT
 * Manfred Albrecht Freiherr **************, known in English as Baron ************** was a fighter pilot with the ****** Air Force during World War I. He is considered the ace-of-aces of the war, being officially credited with ****** combat victories.
 * 
 * 
 * 
 */
