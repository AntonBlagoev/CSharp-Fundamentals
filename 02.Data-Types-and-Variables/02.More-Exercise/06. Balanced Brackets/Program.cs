using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string openingBracket = string.Empty;
            bool balanced = false;

            for (int i = 0; i < n; i++)
            {
                
                string input = Console.ReadLine();
                
                if (input == "(" && openingBracket == string.Empty)
                {
                    openingBracket = "(";
                    balanced = false;
                }
                else if (input == "(" && openingBracket == "(")
                {
                    break;
                }
                else if (input == ")" && openingBracket == "(")
                {
                    balanced = true;
                    openingBracket = string.Empty;
                }

            }

            if (balanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }


        }
    }
}
