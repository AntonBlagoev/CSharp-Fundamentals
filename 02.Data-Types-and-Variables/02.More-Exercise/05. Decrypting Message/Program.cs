using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            
            string message = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                char letterDecrypted = (char)(letters + key);
                message += letterDecrypted;

            }
            Console.WriteLine($"{message}");
        }
    }
}
