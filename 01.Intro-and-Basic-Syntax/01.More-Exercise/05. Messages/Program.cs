using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < numberOfLetters; i++)
            {
                string digits = Console.ReadLine();
                int digitLength = digits.Length;
                int digit = digits[0] - '0'; // get ASCII number of first char - ASCII number of '0' (48)

                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    message += (char)(digit + 32);
                    continue;
                }

                if (digit == 8 || digit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + digitLength - 1;
                message += (char)(letterIndex + 97); // ASCII number 97 = a
            }

            Console.WriteLine(message);
        }
    }
}
