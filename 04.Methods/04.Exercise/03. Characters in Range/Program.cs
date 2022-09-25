using System;
using System.Linq;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            CharactersRangePrint(firstChar, secondChar);
        }

        static void CharactersRangePrint(char firstChar, char secondChar)
        {
            int startChar = Math.Min(firstChar, secondChar);
            int endChar = Math.Max(firstChar, secondChar);

            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}

/* Create a method that receives two characters and prints all the characters between them according to ASCII (on a single line).
 * NOTE: If the second letter's ASCII value is less than that of the first one, then the two initial letters should be swapped.
 * 
 * Input
 * a
 * d
 * Output
 * b c
 * 
 * Input
 * #
 * :
 * Output
 * $ % & ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9
 * 
 * Input
 * C
 * #
 * Output
 * $ % & ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9 : ; < = > ? @ A B
 * 
 */