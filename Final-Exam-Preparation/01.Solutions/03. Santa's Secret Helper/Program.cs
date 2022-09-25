using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string inputMessage = string.Empty;
            while ((inputMessage = Console.ReadLine()) != "end")
            {
                char[] decodeCharArray = inputMessage.ToCharArray();
                for (int j = 0; j < decodeCharArray.Length; j++)
                {
                    decodeCharArray[j] = (char)(decodeCharArray[j] - n);
                }

                string decodedMessage = string.Join("",decodeCharArray);

                Match rgx = Regex.Match(decodedMessage, @"@([A-Za-z]+)[^@\-!:>]+!([GN])!");
                if (rgx.Success)
                {
                    string nameOfChild = rgx.Groups[1].Value;
                    string behaviourType = rgx.Groups[2].Value;

                    if (behaviourType == "G")
                    {
                        Console.WriteLine(nameOfChild);
                    }
                }
            }
        }
    }
}
