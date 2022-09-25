using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> morseDict = new Dictionary<string, string>();
            morseDict.Add(".-", "A");
            morseDict.Add("-...", "B");
            morseDict.Add("-.-.", "C");
            morseDict.Add("-..", "D");
            morseDict.Add(".", "E");
            morseDict.Add("..-.", "F");
            morseDict.Add("--.", "G");
            morseDict.Add("....", "H");
            morseDict.Add("..", "I");
            morseDict.Add(".---", "J");
            morseDict.Add("-.-", "K");
            morseDict.Add(".-..", "L");
            morseDict.Add("--", "M");
            morseDict.Add("-.", "N");
            morseDict.Add("---", "O");
            morseDict.Add(".--.", "P");
            morseDict.Add("--.-", "Q");
            morseDict.Add(".-.", "R");
            morseDict.Add("...", "S");
            morseDict.Add("-", "T");
            morseDict.Add("..-", "U");
            morseDict.Add("...-", "V");
            morseDict.Add(".--", "W");
            morseDict.Add("-..-", "X");
            morseDict.Add("-.--", "Y");
            morseDict.Add("--..", "Z");

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            StringBuilder morseCodeTranslated = new StringBuilder();

            foreach (var item in input)
            {
                if (morseDict.ContainsKey(item))
                {
                    morseCodeTranslated.Append(morseDict[item]);
                }
                if (item == "|")
                {
                    morseCodeTranslated.Append(" ");
                }
            }
            Console.WriteLine(morseCodeTranslated);
        }
    }
}
/* Create a program that translates messages from Morse code to English (capital letters). 
 * Use this page to help you (without the numbers). The words will be separated by a space (' '). 
 * There will be a '|' character which you should replace with ' ' (space).
 * 
 * Input
 * .. | -- .- -.. . |  -.-- --- ..- | .-- .-. .. - . | .- | .-.. --- -. --. | -.-. --- -.. .
 * Output
 * I MADE YOU WRITE A LONG CODE
 * 
 * Input
 * .. | .... --- .--. . | -.-- --- ..- | .- .-. . | -. --- - | -- .- -..
 * Output
 * I HOPE YOU ARE NOT MAD
 * 
 */