using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        public static object List { get; private set; }

        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-z]+)<<(?<price>\d+.?\d+)!(?<quantity>[\d]+)";
            Regex rgx = new Regex(pattern);

            List<string> furnitureList = new List<string>();
            double spendMoney = 0.0;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match matches = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    double price = double.Parse(matches.Groups["price"].Value);
                    int quantity = int.Parse(matches.Groups["quantity"].Value);
                    spendMoney += price * quantity;

                    furnitureList.Add(name);
                }
            }
            Console.WriteLine("Bought furniture:");
            furnitureList.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {spendMoney:f2}");


        }
    }
}

/* Create a program to calculate the total cost of different types of furniture. 
 * You will be given some lines of input, until you receive the line "Purchase". 
 * For the line to be valid it should be in the following format:
 * 
 * ">>{furniture name}<<{price}!{quantity}"
 * The price can be a floating-point number or a whole number. 
 * Store the names of the furniture and the total price. At the end, print each bought furniture on a separate line in the format:
 * "Bought furniture:
 * {1st name}
 * {2nd name}
 * …"
 * And on the last line, print the following: "Total money spend: {spend money}", formatted to the second decimal point.
 * 
 * INPUT
 * >>Sofa<<312.23!3
 * >>TV<<300!5
 * >Invalid<<!5
 * Purchase
 * 
 * OUTPUT
 * Bought furniture:
 * Sofa
 * TV
 * Total money spend: 2436.69
 * 
 * COMMENT
 * Only the Sofa and the TV are valid, for each of them we multiply the price by the quantity and print the result.
 * 
 * 
 * INPUT
 * >>Chair<<412.23!3
 * >>Sofa<<500!5
 * >>Recliner<<<<!5
 * >>Bench<<230!10
 * >>>>>>Rocking chair<<!5
 * >>Bed<<700!5
 * Purchase
 * 
 * OUTPUT
 * Bought furniture:
 * Chair
 * Sofa
 * Bench
 * Bed
 * Total money spend: 9536.69
 * 
 * 
 */
