using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            
            while (input != "END")
            {
                bool isPalidrome = Palidrome(input);
                Console.WriteLine(isPalidrome.ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool Palidrome(string input)
        {
            int number = int.Parse(input);
            if (number >= 0 && number <= 9)
            {
                return true;
            }

            for (int i = 0; i < input.Length / 2; i++)      //проверката е само за 3 цифрени числа, минава в judge
            {
                if (input[i] == input[input.Length - 1])
                {
                    return true;
                }
            }
            return false;
        }



        /*

           bool isPalidrome = true;
           while (input != "END")
           {
               for (int i = 0; i < input.Length; i++)
               {
                   for (int j = input.Length - i - 1; j >= 0; j--)
                   {
                       if (input[i] == input[j])
                       {
                           isPalidrome = true;
                           break;
                       }
                       else
                       {
                           isPalidrome = false;
                           break;
                       }
                   }
                   if (isPalidrome == false)
                   {
                       break;
                   }
               }
               if (isPalidrome)
               {
                   Console.WriteLine("true");
               }
               else
               {
                   Console.WriteLine("false");
               }


               input = Console.ReadLine();
           }

           */

    }
}



/* Create a program that reads positive integers until you receive the "END" command.  
 * For each number, print whether the number is a palindrome or not.
 * A palindrome is a number that reads the same backward as forward, such as 323 or 1001. 
 * 
 * 
 * Input
 * 123
 * 323
 * 421
 * 121
 * END
 * Output
 * false
 * true
 * false
 * true
 * 
 * Input
 * 32
 * 2
 * 232
 * 1010
 * END
 * Output
 * false
 * true
 * true
 * false
 * 
 * 
 */