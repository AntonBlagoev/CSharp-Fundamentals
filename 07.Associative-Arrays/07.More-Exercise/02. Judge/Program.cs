using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] tokens = input.Split(" -> ");
                string name = tokens[0];
                string contestName = tokens[1];
                int points = int.Parse(tokens[2]);


                if (!(userList.Any(x => x.Contest == contestName)))
                {
                    userList.Add(new User(name, contestName, points));
                }
                else if (!(userList.Any(x => x.Contest == contestName && x.Name == name)))
                {
                    userList.Add(new User(name, contestName, points));
                }
                else if (userList.Any(x => x.Contest == contestName && x.Name == name && x.Points < points))
                {
                    int userIndex = userList.FindIndex(x => x.Contest == contestName && x.Name == name);
                    userList[userIndex].Points = points;
                }
            }

            var contestCount = userList
                .GroupBy(x => x.Contest)
                .Select(group => new
                {
                    Name = group.Key,
                    Count = group.Count()
                });

            foreach (var contest in contestCount)
            {
                Console.WriteLine($"{contest.Name}: {contest.Count} participants");

                int positionInContest = 1;
                foreach (User user in userList
                    .Where(x => x.Contest == contest.Name)
                    .OrderByDescending(x => x.Points)
                    .ThenBy(x => x.Name))
                {
                    Console.WriteLine($"{positionInContest}. {user.Name} <::> {user.Points}");
                    positionInContest++;
                }
            }

            Console.WriteLine("Individual standings:");
            var groupOfUsers = userList
                .GroupBy(x => x.Name)
                .Select(group => new
                {
                    Name = group.Key,
                    SumOfPoints = group.Sum(x => x.Points)
                })
                .ToArray()
                .OrderByDescending(x => x.SumOfPoints)
                .ThenBy(x => x.Name);

            int individualPosition = 1;
            foreach (var user in groupOfUsers)
            {
                Console.WriteLine($"{individualPosition}. {user.Name} -> {user.SumOfPoints}");
                individualPosition++;
            }


        }

        class User
        {
            public string Name { get; set; }
            public string Contest { get; set; }
            public int Points { get; set; }
            public User(string name, string contest, int points)
            {
                Name = name;
                Contest = contest;
                Points = points;
            }
        }
    }
}
/* You know the judge system, right? Your job is to create a program similar to the Judge system. 
 * You will receive several input lines in one of the following formats:
 * "{username} -> {contest} -> {points}"
 * The constestName and username are strings, the given points will be an integer number. 
 * You need to keep track of every contest and individual statistics of every user. 
 * You should check if such a contest already exists and if not, add it, otherwise, check if the current user is participating in the contest. 
 * If they are participating, take the higher score, otherwise, just add it. 
 * Also, you need to keep individual statistics for each user - the total points of all contests. 
 * You should end your program when you receive the command "no more time". 
 * At that point, you should print each contest in order of input, 
 * for each contest print the participants ordered by points in descending order, then ordered by name in ascending order. 
 * After that, you should print individual statistics for every participant, ordered by total points in descending order, 
 * and then by alphabetical order.
 * 
 * Input / Constraints
 * •	The input comes in the form of commands in one of the formats specified above.
 * •	Username and contest name always will be one word.
 * •	Points will be an integer in the range [0…1000].
 * •	There will be no invalid input lines.
 * •	If all sorting criteria fail, the order should be by order of input.
 * •	The input ends when you receive the command "no more time".
 * 
 * Output
 * •	The output format for the contests is:
 * "{constestName}: {participants.Count} participants"
 * "{position}. {username} <::> {points}"
 * •	After you print all contests, print the individual statistics for every participant.
 * •	The output format is:
 * "Individual standings:"
 * "{position}. {username} -> {totalPoints}"
 * 
 * Examples
 * 
 * 
 * INPUT
 * Peter -> Algo -> 400
 * George -> Algo -> 300
 * Sam -> Algo -> 200
 * Peter -> DS -> 150
 * Maria -> DS -> 600
 * no more time
 * 
 * OUTPUT
 * Algo: 3 participants
 * 1. Peter <::> 400
 * 2. George <::> 300
 * 3. Sam <::> 200
 * DS: 2 participants
 * 1. Maria <::> 600
 * 2. Peter <::> 150
 * Individual standings:
 * 1. Maria -> 600
 * 2. Peter -> 550
 * 3. George -> 300
 * 4. Sam -> 200
 * 
 * INPUT
 * Peter -> OOP -> 350
 * George -> OOP -> 250
 * Sam -> Advanced -> 600
 * George -> OOP -> 300
 * John -> OOP -> 300
 * John -> Advanced -> 250
 * Anna -> JSCore -> 400
 * no more time
 * 
 * OUTPUT
 * OOP: 3 participants
 * 1. Peter <::> 350
 * 2. George <::> 300
 * 3. John <::> 300
 * Advanced: 2 participants
 * 1. Sam <::> 600
 * 2. John <::> 250
 * JSCore: 1 participants
 * 1. Anna <::> 400
 * Individual standings:
 * 1. Sam -> 600
 * 2. John -> 550
 * 3. Anna -> 400
 * 4. Peter -> 350
 * 5. George -> 300
 * 
 * 
 */