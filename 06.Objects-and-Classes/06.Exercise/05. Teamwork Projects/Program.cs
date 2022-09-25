using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] currTeamInfo = Console.ReadLine().Split('-');
                var creator = currTeamInfo[0];
                var teamName = currTeamInfo[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.Name = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of assignment")
                {
                    break;
                }
                string[] membersInfo = line.Split("->", StringSplitOptions.None);

                var memberName = membersInfo[0];
                var teamToJoin = membersInfo[1];

                if (teams.Any(x => x.Members.Contains(memberName)) || teams.Any(x => x.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }
                else if (teams.All(x => x.Name != teamToJoin)) // може и teams.Any
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    var currentTeam = teams.Find(x => x.Name == teamToJoin);
                    currentTeam.Members.Add(memberName);
                }
            }

            var completedTeams = teams.Where(x => x.Members.Count > 0);
            var disbanedTeams = teams.Where(x => x.Members.Count == 0);

            foreach (var team in completedTeams.OrderByDescending(x => x.Members.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            if (disbanedTeams != null)
            {
                foreach (var disbanedTeam in disbanedTeams.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"{disbanedTeam.Name}");
                }
            }



        }
    }

    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

    }

}
/* It's time for the teamwork projects and you are responsible for gathering the teams. 
 * First, you will receive an integer – the count of the teams you will have to register. 
 * You will be given a user and a team, separated with "-".  The user is the creator of the team. 
 * For every newly created team you should print a message: 
 * "Team {teamName} has been created by {user}!".
 * Next, you will receive а user with a team, separated with "->", which means that the user wants to join that team. 
 * Upon receiving the command: "end of assignment", you should print every team, ordered by the count of its members (descending) 
 * and then by name (ascending). For each team, you have to print its members sorted by name (ascending). However, there are several rules:
 * 
 * •	If а user tries to create a team more than once, a message should be displayed: 
 * -	"Team {teamName} was already created!"
 * 
 * •	A creator of a team cannot create another team – the following message should be thrown: 
 * -	"{user} cannot create another team!"
 * 
 * •	If а user tries to join a non-existent team, a message should be displayed: 
 * -	"Team {teamName} does not exist!"
 * 
 * •	A member of a team cannot join another team – the following message should be thrown:
 * -	"Member {user} cannot join team {team Name}!"
 * 
 * •	In the end, teams with zero members (with only a creator) should disband and you have to print them ordered by name in ascending order.
 * •	 Every valid team should be printed ordered by name (ascending) in the following format:
 * "{teamName}
 * - {creator}
 * -- {member}…"
 * 
 * 
 * INPUT
 * 2
 * John-PowerPuffsCoders
 * Tony-Tony is the best
 * Peter->PowerPuffsCoders
 * Tony->Tony is the best
 * end of assignment 
 * 
 * OUTPUT
 * Team PowerPuffsCoders has been created by John!
 * Team Tony is the best has been created by Tony!
 * Member Tony cannot join team Tony is the best!
 * PowerPuffsCoders
 * - John
 * -- Peter
 * Teams to disband:
 * Tony is the best
 * 
 * COMMENTS
 * Tony created a team, which he attempted to join later and this action resulted in throwing a certain message. 
 * Since nobody else tried to join his team, the team had to disband.
 * 
 * INPUT
 * 3
 * Tanya-CloneClub
 * Helena-CloneClub
 * Tedy-SoftUni
 * George->softUni
 * George->SoftUni
 * Tatyana->Leda
 * John->SoftUni
 * Cossima->CloneClub
 * end of assignment
 * 
 * OUTPUT
 * Team CloneClub has been created by Tanya!
 * Team CloneClub was already created!
 * Team SoftUni has been created by Tedy!
 * Team softUni does not exist!
 * Team Leda does not exist!
 * SoftUni
 * - Tedy
 * -- George
 * -- John
 * CloneClub
 * - Tanya
 * -- Cossima
 * Teams to disband:
 * 
 * COMMENTS
 * Note that when a user joins a team, you should first check if the team exists and then check if the user is already in a team:
 * Tanya has created CloneClub, then she tried to join a non-existent team and the concrete message was displayed.
 * 
 * 
 */