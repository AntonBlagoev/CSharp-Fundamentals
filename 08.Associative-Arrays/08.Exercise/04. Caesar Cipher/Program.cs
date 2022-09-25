using System;


namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputChars = Console.ReadLine().ToCharArray();

            for (int i = 0; i < inputChars.Length; i++)
            {
                inputChars[i] = (char)(inputChars[i] + 3);
            }
            Console.Write(string.Join("", inputChars));
        }
    }
}
/* Create a program that returns an encrypted version of the same text. 
 * Encrypt the text by shifting each character with three positions forward.
 * For example, A would be replaced by D, B would become E and so on. Print the encrypted text.
 * 
 * Input
 * Programming is cool!
 * Output
 * Surjudpplqj#lv#frro$
 * 
 * Input
 * One year has 365 days.
 * Output
 * Rqh#|hdu#kdv#698#gd|v1
 * 
 */