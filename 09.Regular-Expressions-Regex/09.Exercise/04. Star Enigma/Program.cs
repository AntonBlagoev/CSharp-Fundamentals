using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> planetsDict = new Dictionary<string, List<string>>(); // or with 2 lsts - Attacked & Destroyed
            planetsDict.Add("A", new List<string>());
            planetsDict.Add("D", new List<string>());

            string pattern = @"@([A-z]+)[^@\-!:>]*:(\d+)[^@\-!:]*!([A,D])![^@\-!:]*->(\d+)";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matchedLetters = Regex.Matches(input, @"[STARstar]");
                int lettersCount = matchedLetters.Count;

                //StringBuilder sb = new StringBuilder();
                //for (int j = 0; j < input.Length; j++)
                //{
                //    sb.Append((char)(input[j] - lettersCount));  //message[j] = (char)(message[j] - 3);
                //}
                //string message = (string.Join("", sb));

                string message = string.Empty;
                foreach (var symbol in input)
                {
                    message += (char)(symbol - lettersCount);
                }

                //Regex rgx = new Regex(@"@([A-z]+)[^@\-!:>]*:(\d+)[^@\-!:]*!([A,D])![^@\-!:]*->(\d+)"); 
                //bool isValid = rgx.IsMatch(message);

                Match rgx = Regex.Match(message, pattern, RegexOptions.IgnoreCase);
                if (rgx.Success)
                {
                    string planetName = rgx.Groups[1].Value; //rgx.Match(message).Groups[1].Value;
                    int population = int.Parse(rgx.Groups[2].Value);
                    string attackType = rgx.Groups[3].Value;
                    int soldierCount = int.Parse(rgx.Groups[4].Value);

                    planetsDict[attackType].Add(planetName);
                }
            }

            foreach (var planet in planetsDict)
            {
                string attackString = string.Empty;
                if (planet.Key == "A")
                {
                    attackString = "Attacked";
                }
                else
                {
                    attackString = "Destroyed";
                }
                Console.WriteLine($"{attackString} planets: {planet.Value.Count}");

                foreach (var item in planet.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}
/* The war is at its peak, but you, young Padawan, can turn the tides with your programming skills. 
 * You are tasked to create a program to decrypt the messages of The Order and prevent the death of hundreds of lives. 
 * You will receive several messages, which are encrypted, using the legendary star enigma. 
 * You should decrypt the messages, following these rules:
 * To properly decrypt a message, you should count all the letters [s, t, a, r] – case insensitive 
 * and remove the count from the current ASCII value of each symbol of the encrypted message.
 * 
 * After decryption:
 * •	Each message should have a planet name, population, attack type ('A' as an attack or 'D'  as destruction), and soldier count.
 * •	The planet name starts after '@' and contains only letters from the Latin alphabet. 
 * •	The planet population starts after ':' and is an Integer.
 * •	The attack type may be "A"(attack) or "D"(destruction) and must be surrounded by "!" (exclamation mark).
 * •	The soldier count starts after "->" and should be an Integer.
 * The order in the message should be: planet name -> planet population -> attack type -> soldier count. 
 * Each part can be separated from the others by any character except '@', '-', '!', ':' and '>'.
 * 
 * Input / Constraints
 * •	The first line holds n – the number of messages– integer in the range [1…100].
 * •	On the next n lines, you will be receiving encrypted messages.
 * 
 * Output
 * After decrypting all messages, you should print the decrypted information in the following format:
 * First print the attacked planets, then the destroyed planets.
 * "Attacked planets: {attackedPlanetsCount}"
 * "-> {planetName}"
 * "Destroyed planets: {destroyedPlanetsCount}"
 * "-> {planetName}"
 * The planets should be ordered by name alphabetically.
 * Examples
 * 
 * 
 * INPUT
 * 2
 * STCDoghudd4=63333$D$0A53333
 * EHfsytsnhf?8555&I&2C9555SR
 * 
 * 
 * OUTPUT
 * Attacked planets: 1
 * -> Alderaa
 * Destroyed planets: 1
 * -> Cantonica
 * 
 * 
 * COMMENTS
 * 2
 * STCDoghudd4=63333$D$0A53333
 * EHfsytsnhf?8555&I&2C9555SR	Attacked planets: 1
 * -> Alderaa
 * Destroyed planets: 1
 * -> Cantonica	We receive two messages, to decrypt them we calculate the key:
 * The first message has decryption key 3. So we subtract from each character's code 3.
 * PQ@Alderaa1:30000!A!->20000
 * The second message has key 5.
 * @Cantonica:3000!D!->4000NM
 * Both messages are valid and they contain planet, population, attack type and soldiers count. 
 * After decrypting all messages we print each planet according to the format given.
 * 
 * 
 * INPUT
 * 3
 * tt(''DGsvywgerx>6444444444%H%1B9444
 * GQhrr|A977777(H(TTTT
 * EHfsytsnhf?8555&I&2C9555SR
 * 
 * 
 * OUTPUT
 * Attacked planets: 0
 * Destroyed planets: 2
 * -> Cantonica
 * -> Coruscant
 * 
 * 
 * COMMENTS
 * We receive three messages.
 * Message one is decrypted with key 4:
 * pp$##@Coruscant:2000000000!D!->5000
 * Message two is decrypted with key 7:
 * @Jakku:200000!A!MMMM
 * This is an invalid message, missing soldier count, so we continue.
 * The third message has key 5.
 * @Cantonica:3000!D!->4000NM
 * 
 * 
 */