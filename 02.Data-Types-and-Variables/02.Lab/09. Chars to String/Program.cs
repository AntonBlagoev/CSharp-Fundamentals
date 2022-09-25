using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());


            Console.WriteLine($"{char1}{char2}{char3}");
            //Console.WriteLine("{0}{1}{2}", char1, char2, char3);

        }
    }
}
