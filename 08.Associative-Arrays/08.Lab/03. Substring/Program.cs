using System;
using System.Linq;
using System.Text;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            while (secondString.Contains(firstString))
            {
                secondString = secondString.Replace(firstString, "");
            }

            Console.WriteLine(secondString);
        }
    }
}
/* On the first line, you will receive a string. On the second line, you will receive a second string. 
 * Create a program that removes all of the occurrences of the first string in the second, until there is no match. 
 * At the end print the remaining string.
 * 
 * INPUT
 * ice
 * kicegiciceeb
 * 
 * OUTPUT
 * kgb
 * 
 * COMMENT
 * We remove "ice" once and we get "kgiciceeb"
 * We match "ice" one more time and we get "kgiceb"
 * There is one more match. The finam result is "kgb"
 * 
 * INPUT
 * hep
 * ShepoftunihepIsGrhepeat
 * 
 * OUTPUT
 * SoftuniIsGreat
 * 
 */
