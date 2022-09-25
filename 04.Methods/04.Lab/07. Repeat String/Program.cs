using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(str, count);
            Console.Write(result);

        }
        static string RepeatString(string str, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
                result.Append(str);
            return result.ToString();
        }
    }
}

/* Create a method that receives two parameters:
 * •	A string 
 * •	A number n (integer) represents how many times the string will be repeated
 * The method should return a new string, containing the initial one, repeated n times without space. 
 * 
 * Input
 * abc
 * 3
 * Output
 * abcabcabc
 * 
 * Input
 * String
 * 2
 * Output
 * StringString
 * 
 * 
 * 
 */