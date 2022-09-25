using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace _01._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTickets = Regex.Split(Console.ReadLine(), @"[\,\s]+").ToArray();
            //string[] inputTickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in inputTickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine($"invalid ticket");
                    continue;
                }

                string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
                Match matchedLeftSide = Regex.Match(ticket.Substring(0, 10), pattern);
                Match matchedRightSide = Regex.Match(ticket.Substring(10), pattern);
                int minLenght = Math.Min(matchedLeftSide.Length, matchedRightSide.Length); // !!!

                if (!(matchedLeftSide.Success && matchedRightSide.Success))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }

                if (matchedLeftSide.Value.Substring(0, minLenght).Equals(matchedRightSide.Value.Substring(0, minLenght)))
                {
                    var firstChar = matchedLeftSide.Value[0];

                    if (minLenght == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {minLenght}{firstChar} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {minLenght}{firstChar}");
                    }
                }
            }
        }
    }
}

/* The lottery is exciting. What is not, is checking a million tickets for winnings only by hand. 
 * So, you are given the task to create a program that automatically checks if a ticket is a winner. 
 * You are given a collection of tickets separated by commas and spaces. 
 * You need to check every one of them if they have a winning combination of symbols.
 * A valid ticket should have exactly 20 characters. The winning symbols are '@', '#', '$' and '^'. 
 * But for a ticket to be a winner the symbol should uninterruptedly repeat at least 6 times 
 * in both the tickets left half and the tickets right half. 
 * For example, a valid winning ticket should be something like this: 
 * "Cash$$$$$$Ca$$$$$$sh" 
 * The left half "Cash$$$$$$" contains "$$$$$$", which is also contained in the tickets right half "Ca$$$$$$sh". 
 * A winning ticket should contain symbols repeating up to 10 times in both halves, which is considered a Jackpot 
 * (for example "$$$$$$$$$$$$$$$$$$$$").
 * 
 * Input
 * The input will be read from the console. 
 * The input consists of a single line, containing all tickets separated by commas and one or more white spaces in the format:
 * •	"{ticket}, {ticket}, … {ticket}"
 * 
 * Output
 * Print the result for every ticket in the order of their appearance, each on a separate line in the format:
 * •	Invalid ticket - "invalid ticket"
 * •	No match - "ticket "{ticket}" - no match"
 * •	Match with length 6 to 9 - "ticket "{ticket}" - {match length}{match symbol}"
 * •	Match with length 10 - "ticket "{ticket}" - {match length}{match symbol} Jackpot!"
 * 
 * Constrains
 * •	The number of tickets will be in the range [0…100].
 * 
 * Examples
 * 
 * 
 * INPUT
 * Cash$$$$$$Ca$$$$$$sh
 * 
 * OUTPUT
 * ticket "Cash$$$$$$Ca$$$$$$sh" - 6$
 * 
 * INPUT
 * $$$$$$$$$$$$$$$$$$$$, aabb  , th@@@@@@eemo@@@@@@ey
 * 
 * OUTPUT
 * ticket "$$$$$$$$$$$$$$$$$$$$" - 10$ Jackpot!
 * invalid ticket
 * ticket "th@@@@@@eemo@@@@@@ey" - 6@
 * 
 * INPUT
 * validticketnomatch:(
 * 
 * OUTPUT
 * ticket "validticketnomatch:(" - no match
 * 
 * COMMENT
 * 
 */
