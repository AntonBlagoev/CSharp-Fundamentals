using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacters(input);
        }

        static void PrintMiddleCharacters(string input)
        {
            if (input.Length % 2 == 0) // процентно деление ... при 7 = 3
            {
                Console.Write(input[input.Length / 2 - 1]);
                Console.Write(input[input.Length / 2]);

                /*
                for (int i = (input.Length / 2) - 1; i < (input.Length / 2) + 1; i++)
                {
                    Console.Write((char)input[i]);
                }
                */
            }
            else
            {
                Console.Write(input[input.Length / 2]);
                /*
                for (int i = (input.Length / 2); i <= (input.Length / 2); i++ )
                {
                    Console.Write((char)input[i]);
                }
                */
            }
        }
    }
}


/* You will receive a single string.
 * Create a method that prints the character found at its middle. 
 * If the length of the string is even, there are two middle characters.
 * 
 * Input
 * aString
 * Output
 * r
 * 
 * Input
 * someText
 * Output
 * eT
 * 
 * Input
 * 3245
 * Output
 * 24
 * 
 */