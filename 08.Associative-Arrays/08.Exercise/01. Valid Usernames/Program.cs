using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUserNames = new List<string>();

            foreach (var user in users)
            {
                bool isValidUser = true;

                if (user.Length < 3 || user.Length > 16)
                {
                    isValidUser = false;
                    continue;
                }
                char[] otherSymbols = user.Where(x => !Char.IsLetterOrDigit(x)).ToArray();

                for (int j = 0; j < otherSymbols.Length; j++)
                {
                    if (otherSymbols[j] != '-' && otherSymbols[j] != '_')
                    {
                        isValidUser = false;
                        break;
                    }
                }

                if (isValidUser)
                {
                    validUserNames.Add(user);
                }
            }

            //List<string> validUserNames = users.Where(user => user.All(c => c == '-' || c == '_' || Char.IsLetterOrDigit(c)) && user.Length >= 3 && user.Length <= 16).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, validUserNames));

        }
    }
}

/* Create a program that reads user names on a single line (joined by ", ") and prints all valid usernames. 
 * A valid username
 * •	has length between 3 and 16 characters
 * •	contains only letters, numbers, hyphens and underscores
 * 
 * Input
 * sh, too_long_username, !lleg@l ch@rs, jeffbutt
 * Output
 * jeffbutt
 * 
 * Input
 * Jeff, john45, ab, cd, peter-ivanov, @smith
 * Output
 * Jeff
 * John45
 * peter-ivanov
 * 
 */
