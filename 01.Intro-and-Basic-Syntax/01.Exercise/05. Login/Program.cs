using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            bool correcttUser = false;
            string reverseUserName = "";

            for (int j = userName.Length - 1; j >= 0; j--)
            {
                reverseUserName += userName[j];
            }
            for (int i = 0; i < 4; i++)
            {
                string userPassword = Console.ReadLine();

                if (userPassword != reverseUserName)
                {
                    if (i < 3)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"User {userName} blocked!");
                    }
                }
                else
                {
                    correcttUser = true;
                    break;
                }
            }
            if (correcttUser)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
