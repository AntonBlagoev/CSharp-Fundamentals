using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerPool = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] commands = input.Split(' ');

                if (commands[1] == "->")
                {

                    string player = commands[0];
                    string position = commands[2];
                    int skill = int.Parse(commands[4]);

                    if (!playerPool.ContainsKey(player))
                    {
                        playerPool.Add(player, new Dictionary<string, int>());
                        playerPool[player].Add(position, skill);
                    }
                    else if (!playerPool[player].ContainsKey(position))
                    {
                        playerPool[player].Add(position, skill);
                    }
                    else if (playerPool[player][position] < skill)
                    {
                        playerPool[player][position] = skill;
                    }
                }
                else
                {
                    string playerOne = commands[0];
                    string playerTwo = commands[2];

                    if (!(playerPool.ContainsKey(playerOne)) || !(playerPool.ContainsKey(playerTwo)))
                    {
                        continue;
                    }
                    else
                    {
                        string commonPosition = string.Empty;
                        bool stopCicle = false;

                        foreach (var playerOnePosition in playerPool[playerOne])
                        {
                            foreach (var playerTwoPosition in playerPool[playerTwo])
                            {
                                if (playerOnePosition.Key == playerTwoPosition.Key)
                                {
                                    commonPosition = playerOnePosition.Key;
                                    stopCicle = true;
                                    break;
                                }
                            }
                            if (stopCicle)
                            {
                                break;
                            }
                        }
                        if (commonPosition == "")
                        {
                            continue;
                        }
                        else if (playerPool[playerOne][commonPosition] > playerPool[playerTwo][commonPosition])
                        {
                            playerPool.Remove(playerTwo);
                        }
                        else
                        {
                            playerPool.Remove(playerOne);
                        }
                    }
                }
            }

            foreach (var player in playerPool
                .OrderByDescending(x => x.Value.Sum(x => x.Value))
                .ThenBy(x => x.Key))
            {
                int totalSum = player.Value.Sum(x => x.Value);
                Console.WriteLine($"{player.Key}: {totalSum} skill");

                foreach (var position in player.Value
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }



        }
    }
}
/* Peter is a pro-MOBA player, he is struggling to become а master of the Challenger tier. So he watches carefully the statistics in the tier.
 * You will receive several input lines in one of the following formats:
 * "{player} -> {position} -> {skill}"
 * "{player} vs {player}"
 * The player and position are strings, the given skill will be an integer number. You need to keep track of every player. 
 * When you receive a player and their position and skill, add them to the player pool, if they aren't present, 
 * else add their position and skill or update their skill, only if the current position skill is lower than the new value.
 * If you receive "{player} vs {player}" and both players exist in the tier, they duel with the following rules:
 * Compare their positions, if they have at least one in common, 
 * the player with better total skill points wins and the other is demoted from the tier -> remove him/her. If they have the same total skill points, 
 * the duel is a tie and they both continue in the season.
 * If they don't have positions in common, the duel isn't happening and both continue in the Season.
 * You should end your program when you receive the command "Season end". 
 * At that point, you should print the players, ordered by total skill in descending order, then ordered by player name in ascending order. 
 * Foreach player print their position and skill, ordered descending by skill, then ordered by position name in ascending order.
 * 
 * Input / Constraints
 * •	The input comes in the form of commands in one of the formats specified above.
 * •	Player and position will always be one-word string, containing no whitespaces.
 * •	Skill will be an integer in the range [0…1000].
 * •	There will be no invalid input lines.
 * •	The programm ends when you receive the command "Season end".
 * 
 * Output
 * •	The output format for each player is:
 * "{player}: {totalSkill} skill"
 * "- {position} <::> {skill}"
 * 
 * Examples
 * 
 * INPUT
 * Peter -> Adc -> 400
 * George -> Jungle -> 300
 * Sam -> Mid -> 200
 * Sam -> Support -> 250
 * Season end
 * 
 * OUTPUT
 * Sam: 450 skill
 * - Support <::> 250
 * - Mid <::> 200
 * Peter: 400 skill
 * - Adc <::> 400
 * George: 300 skill
 * - Jungle <::> 300
 * 
 * COMMENTS
 * We order the players by total skill points descending, then by name. 
 * We print every position along its skill ordered descending by skill, then by position name.
 * 
 * INPUT
 * Peter -> Adc -> 400
 * Bush -> Tank -> 150
 * Faker -> Mid -> 200
 * Faker -> Support -> 250
 * Faker -> Tank -> 250
 * Peter vs Faker
 * Faker vs Bush
 * Faker vs Hide
 * Season end
 * 
 * OUTPUT
 * Faker: 700 skill
 * - Support <::> 250
 * - Tank <::> 250
 * - Mid <::> 200
 * Peter: 400 skill
 * - Adc <::> 400
 * 
 * COMMENTS
 * Faker and Peter don`t have a common position, so the duel isn`t valid.
 * Faker wins vs Bush /common position: "Tank". Bush is demoted.
 * Hide doesn`t exist so the duel isn`t valid.
 * We print every player left in the tier.
 * 
 * 
 */