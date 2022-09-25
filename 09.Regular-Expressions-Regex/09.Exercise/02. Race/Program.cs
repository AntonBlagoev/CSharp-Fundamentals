using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex rgxName = new Regex(@"[A-Za-z]");
            Regex rgxDigit = new Regex(@"[0-9]");

            Dictionary<string, int> participantsDict = new Dictionary<string, int>();
            List<string> inputList = new List<string>();

            string[] participantNames = Console.ReadLine().Split(", ");
            foreach (var participant in participantNames)
            {
                participantsDict.Add(participant, 0);
            }
            
            string input = string.Empty;
            while (!((input = Console.ReadLine()) == "end of race"))
            {
                inputList.Add(input);
            }

            foreach (var item in inputList)
            {
                MatchCollection matchedName = rgxName.Matches(item);
                MatchCollection matchedDigit = rgxDigit.Matches(item);

                string racerName = string.Join("", matchedName);
                int racerKm = 0;

                foreach (Match km in matchedDigit)
                {
                    racerKm += int.Parse(km.Value);
                }

                if (participantsDict.ContainsKey(racerName))
                {
                    participantsDict[racerName] += racerKm;
                }
            }

            //var winners = participantsDict.OrderByDescending(x => x.Value).Take(3);
            
            int count = 1;
            string countString = string.Empty;

            foreach (var participant in participantsDict
                .OrderByDescending(x => x.Value)
                .Take(3)
                )
            {
                if (count == 1)
                {
                    countString = "st";
                }
                else if (count == 2)
                {
                    countString = "nd";
                }
                else
                {
                    countString = "rd";
                }
                Console.WriteLine($"{count}{countString} place: {participant.Key}");
                count++;
            }
        }
    }
}


/* Write a program that processes information about a race. On the first line, you will be given a list of participants separated by ", ". 
 * On the next few lines, until you receive a line "end of the race", you will be given some info which will be some alphanumeric characters. 
 * In between them, you could have some extra characters which you should ignore. For example: "G!32e%o7r#32g$235@!2e". 
 * The letters are the name of the person and the sum of the digits is the distance he ran. 
 * So here we have George who ran 29 km. Store the information about the person only if the list of racers contains the name of the person.
 * If you receive the same person more than once, just add the distance to his old distance. At the end print the top 3 racers in the format:
 * 
 * "1st place: {first racer}
 * 2nd place: {second racer}
 * 3rd place: {third racer}"
 * 
 * INPUT
 * George, Peter, Bill, Tom
 * G4e@55or%6g6!68e!!@
 * R1@!3a$y4456@
 * B5@i@#123ll
 * G@e54o$r6ge#
 * 7P%et^#e5346r
 * T$o553m&6
 * end of race
 * 
 * OUTPUT
 * 1st place: George
 * 2nd place: Peter
 * 3rd place: Tom 
 * 
 * COMMENT
 * On the 3rd input line, we have Ray. He is not on the list, so we do not count his result. The other ones are valid. 
 * George has a total of 55 km, Peter has 25 and Tom has 19. We do not print Bill because he is in 4th place.
 * 
 * INPUT
 * Ivan, Peter, James, KyleI4v@43an%66?77!!@
 * G1@!3u$s445s6@
 * B3@i@#245ll
 * I&v54a%66n@
 * ++7P%et^#e5346r
 * J$a553m&e6s
 * K2y3=l/^e23
 * end of race
 * 
 * OUTPUT
 * 1st place: Ivan
 * 2nd place: Peter
 * 3rd place: James
 * 
 * 
 */
