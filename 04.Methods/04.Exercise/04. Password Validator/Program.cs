using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();

            bool isPasswordLenghtValid = CheckPasswordLenght(inputPassword);
            bool isPasswordLettersValid = CheckPasswordLetters(inputPassword);
            bool isPasswordDigitstValid = CheckPasswordDigits(inputPassword);

            if (!isPasswordLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordLettersValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if(!isPasswordDigitstValid)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isPasswordLenghtValid && isPasswordLettersValid && isPasswordDigitstValid)
            {
                Console.WriteLine("Password is valid");
            }
        }


        static bool CheckPasswordLenght(string inputPassword)
        {
            return inputPassword.Length >= 6 && inputPassword.Length <= 10;
        }

        static bool CheckPasswordLetters(string inputPassword)
        {
            foreach (char symbol in inputPassword)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;  
                }
            }
            return true;
        }

        static bool CheckPasswordDigits(string inputPassword)
        {

            int count = 0;
            foreach (char symbol in inputPassword)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }

            return count >= 2;
        }
    }
}


/* Create a program that checks if a given password is valid.
 * The password validation rules are:
 * •	It should contain 6 – 10 characters (inclusive)
 * •	It should contain only letters and digits
 * •	It should contain at least 2 digits 
 * If it is not valid, for any unfulfilled rule print the corresponding message:
 * •	"Password must be between 6 and 10 characters"
 * •	"Password must consist only of letters and digits"
 * •	"Password must have at least 2 digits"
 * 
 * 
 * Input
 * logIn
 * Output
 * Password must be between 6 and 10 characters 
 * Password must have at least 2 digits
 * 
 * Input
 * MyPass123
 * Output
 * Password is valid
 * 
 * Input
 * Pa$s$s
 * Output
 * Password must consist only of letters and digits
 * Password must have at least 2 digits
 * 
 */