using System;
using System.Text;
using System.Linq;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            //StringBuilder digits = new StringBuilder();
            //StringBuilder letters = new StringBuilder();
            //StringBuilder others = new StringBuilder();

            //for (int i = 0; i < inputText.Length; i++)
            //{
            //    if (Char.IsDigit(inputText[i]))
            //    {
            //        digits.Append(inputText[i]);
            //    }
            //    else if (Char.IsLetter(inputText[i]))
            //    {
            //        letters.Append(inputText[i]);
            //    }
            //    else
            //    {
            //        others.Append(inputText[i]);
            //    }
            //}

            // USING LINQ

            char[] digits = inputText.Where(x => Char.IsDigit(x)).ToArray();
            char[] letters = inputText.Where(x => Char.IsLetter(x)).ToArray();
            char[] others = inputText.Where(x => !Char.IsLetterOrDigit(x)).ToArray();

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);

        }
    }
}

/* Create a program that receives a single string and prints all the digits on the first line, 
 * on the second – all the letters, and on the third – all the other characters. 
 * There will always be at least one digit, one letter and one other character.
 * 
 * Input
 * Agd#53Dfg^&4F53
 * 
 * Output
 * 53453
 * AgdDfgF
 * #^&
 * 
 * Input
 * So%f94t34U*n&i></37
 * 
 * Output
 * 943437
 * SoftUni
 * %*&></
 * 
 */
