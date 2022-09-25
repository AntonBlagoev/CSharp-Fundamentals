using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentBarcode = Console.ReadLine();

                if (Regex.IsMatch(currentBarcode, @"@#+[A-Z][a-zA-Z\d]{4,}[A-Z]@#+"))
                {
                    char[] digits = currentBarcode.Where(char.IsDigit).ToArray();

                    string productGroup = digits.Length == 0 ? "00" : string.Join("", digits); // short way

                    //string productGroup = string.Empty;
                    //if (digits.Length == 0)
                    //{
                    //    productGroup = "00";
                    //}
                    //else
                    //{
                    //    productGroup = string.Join("", digits);
                    //}

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
