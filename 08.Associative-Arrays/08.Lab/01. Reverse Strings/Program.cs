using System;
using System.Linq;
using System.Text;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();

                if (word == "end")
                {
                    break;
                }

                string reversedWord = string.Empty;

                //for (int i = word.Length - 1; i >= 0; i--)
                //{
                //    reversedWord += word[i];
                //}

                reversedWord = string.Join("", word.ToCharArray().Reverse());
                Console.WriteLine($"{word} = {reversedWord}");
            }
        }
    }
}

/* You will be given a series of strings, until you receive an "end" command. 
 * Write a program that reverses strings and prints each pair on a separate line in the format "{word} = {reversed word}".
 * 
 * Examples
 * 
 * INPUT
 * helLo
 * Softuni
 * bottle
 * end
 * 
 * OUTPUT
 * helLo = oLleh
 * Softuni = inutfoS
 * bottle = elttob
 * 
 * INPUT
 * Dog
 * caT
 * chAir
 * end
 * 
 * OUTPUT
 * Dog = goD
 * caT = Tac
 * chAir = riAhc
 * 
 */
