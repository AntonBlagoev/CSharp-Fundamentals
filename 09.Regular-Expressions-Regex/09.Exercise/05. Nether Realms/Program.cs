﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Regex.Split(Console.ReadLine(), @"[\,\s]+").OrderBy(x => x).ToArray();

            //Regex rgxName = new Regex(@"[^\d\+\-\*/\.\,]");
            //Regex rgxDigits = new Regex(@"-?\d+\.?\d*");
            //Regex rgxMultiDiv = new Regex(@"[\*\/]");

            foreach (var demon in demons)
            {
                var healthMatched = Regex.Matches(demon, @"[^\d\+\-\*/\.\,]");  //MatchCollection matchedName = rgxName.Matches(demon);
                var damageMatched = Regex.Matches(demon, @"-?\d+\.?\d*");       //MatchCollection matchedDigits = rgxDigits.Matches(demon);
                var multiplyDividMatched = Regex.Matches(demon, @"[\*\/]");     //MatchCollection matchedMultiDiv = rgxMultiDiv.Matches(demon);

                string demonName = demon;
                int health = 0;
                double damage = 0.0;

                foreach (Match match in healthMatched)              //for (int i = 0; i < healthMatched.Count; i++)
                {                                                   //{
                    char currChar = char.Parse(match.ToString());   //      health += char.Parse(healthMatched[i].Value);
                    health += currChar;                             //}  
                }                                                       

                foreach (Match match in damageMatched)                  //for (int i = 0; i < damageMatched.Count; i++)
                {                                                       //{
                    double currDamage = double.Parse(match.ToString()); //    damage += double.Parse(damageMatched[i].Value);
                    damage += currDamage;                               //}
                }

                foreach (Match match in multiplyDividMatched)                   //for (int i = 0; i < multiplyDividMatched.Count; i++)
                {                                                               //{
                    if (char.Parse(multiplyDividMatched.ToString()) == '*')     //    if (char.Parse(multiplyDividMatched[i].Value) == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }
                Console.WriteLine($"{demonName} - {health} health, {damage:f2} damage");
            }
        }
    }
}

/* A mighty battle is coming. In the stormy nether realms, demons are fighting against each other 
 * for supremacy in a duel from which only one will survive. 
 * Your job, however, is not so exciting. You are assigned to sign in all the participants in the nether realm's mighty battle's demon book, 
 * which of course is sorted alphabetically. 
 * 
 * A demon's name contains his health and his damage. 
 * 
 * The sum of the asci codes of all characters (excluding numbers (0-9), arithmetic symbols ('+', '-', '*', '/') 
 * 
 * and delimiter dot ('.')) gives a demon's total health. 
 * 
 * The sum of all numbers in his name forms his base damage. 
 * Note that you should consider the plus '+' and minus '-' signs (e.g. +10 is 10 and -10 is -10). 
 * However, there are some symbols ('*' and '/') that can further alter the base damage by multiplying 
 * or dividing it by 2 (e.g. in the name "m15*\/ c - 5.0", the base damage is 15 + (-5.0) = 10 and then you need to multiply it by 2 (e.g. 10 * 2 = 20) and then divide it by 2 (e.g. 20 / 2 = 10)). 
 * 
 * 
 * So, multiplication and division are applied only after all numbers are included in the calculation and in the order they appear in the name.
 * You will get all demons on a single line, separated by commas and zero or more blank spaces. 
 * Sort them in alphabetical order and print their names along with their health and damage. 
 * 
 * Input
 * The input will be read from the console. 
 * The input consists of a single line containing all demon names separated by commas and zero 
 * or more spaces in the format: "{demon name}, {demon name}, … {demon name}"
 * 
 * Output
 * Print all demons sorted by their name in ascending order, each on a separate line in the format:
 * •	"{demon name} - {health points} health, {damage points} damage"
 * 
 * Constraints
 * •	A demon's name will contain at least one character.
 * •	A demon's name cannot contain blank spaces ' ' or commas ','.
 * •	A floating-point number will always have digits before and after its decimal separator.
 * •	Number in a demon's name is considered everything that is a valid integer or floating point number (with dot '.' used as separator). 
 * For example, all these are valid numbers: '4', '+4', '-4', '3.5', '+3.5', '-3.5'.
 * 
 * Examples
 * 
 * 
 * INPUT
 * M3ph-0.5s-0.5t0.0**
 * 
 * OUTPUT
 * M3ph-0.5s-0.5t0.0** - 524 health, 8.00 damage
 * 
 * COMMENTS
 * M3ph-0.5s-0.5t0.0**:
 * Health = 'M' + 'p' + 'h' + 's' + 't' = 524 health.
 * Damage = (3 + (-0.5) + (-0.5) + 0.0) * 2 * 2 = 8 damage.
 * 
 * INPUT
 * M3ph1st0**, Azazel
 * 
 * OUTPUT
 * Azazel - 615 health, 0.00 damage 
 * M3ph1st0** - 524 health, 16.00 damage
 * 
 * 
 * COMMENTS 
 * Azazel: 
 * Health - 'A' + 'z' + 'a' + 'z' + 'e' + 'l' = 615 health. Damage - no digits = 0 damage.
 * M3ph1st0**:
 * Health - 'M' + 'p' + 'h' + 's' + 't' = 524 health.
 * Damage - (3 + 1 + 0) * 2 * 2 = 16 damage. * 
 * 
 * 
 * 
 */
