﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[+][359]+ [2] [0-9]{3} [0-9]{4}|[+][359]+-[2]-[0-9]{3}-[0-9]{4}\b";
            Regex rgx = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matchedNumbers = rgx.Matches(input);

            Console.WriteLine(string.Join(", ", matchedNumbers));

            //var matchedPhones = matchedNumbers
            //    .Cast<Match>()
            //    .Select(x => x.Value.Trim())
            //    .ToArray();
            //Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
/* Create a regular expression to match a valid phone number from Sofia. 
 * After you find all valid phones, print them on the console, separated by a comma and a space ", ".
 * 
 * Compose the Regular Expression
 * A valid number has the following characteristics:
 * •	It starts with "+359"
 * •	Then, it is followed by the area code (always 2)
 * •	After that, it's followed by the number itself:
 * 
 *           o	The number consists of 7 digits (separated into two groups of 3 and 4 digits respectively). 
 *      
 * •	The different parts are separated by either a space or a hyphen ('-').
 * 
 * You can use the following RegEx properties to help with the matching: 
 * •	Use quantifiers to match a specific number of digits
 * •	Use a capturing group to make sure the delimiter is only one of the allowed characters (space or hyphen)
 *      and not a combination of both (e.g. +359 2-111 111 has mixed delimiters, it is invalid). Use a group backreference to achieve this.
 * •	Add a word boundary at the end of the match to avoid partial matches (the last example on the right-hand side).
 * •	Ensure that before the '+' sign there is either a space or the beginning of the string.
 * 
 * You can use the following table of values to test your RegEx against:
 * 
 * Input
 * 359-2-222-2222, +359/2/222/2222, +359-2 222 2222
 * +359 2-222-2222, +359-2-222-222, +359-2-222-22222
 * 
 * Output
 * +359 2 222 2222
 * +359-2-222-2222
 * 
 */
