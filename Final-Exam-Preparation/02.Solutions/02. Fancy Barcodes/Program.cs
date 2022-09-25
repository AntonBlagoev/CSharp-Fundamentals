using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfBarcodes = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfBarcodes; i++)
            {
                string inputBarcode = Console.ReadLine();

                Match validBarcode = Regex.Match(inputBarcode, @"([@]{1}[#]{1,})([A-Z][a-zA-Z0-9]{4,}[A-Z])([@]{1}[#]{1,})");

                if (!validBarcode.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                string productGroup = "00";
                MatchCollection validProductGroup = Regex.Matches(validBarcode.Groups[2].Value, @"\d");
                if (validProductGroup.Count > 0)
                {
                    productGroup = string.Join("", validProductGroup);
                }
                Console.WriteLine($"Product group: {productGroup}");
            }
        }
    }
}
