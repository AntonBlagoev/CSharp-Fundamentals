using System;
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
                string barcode = Console.ReadLine();

                Match barcodeMatch = Regex.Match(barcode, @"@#+([A-Z][a-zA-Z0-9]{4,}[A-Z])@#+");

                if (!barcodeMatch.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                MatchCollection productGroupMatches = Regex.Matches(barcodeMatch.Groups[1].Value, @"\d");
                string productGroup = "00";
                if (productGroupMatches.Count > 0)
                {
                    productGroup = string.Join("", productGroupMatches);
                }
                Console.WriteLine($"Product group: {productGroup}");
            }
        }
    }
}
