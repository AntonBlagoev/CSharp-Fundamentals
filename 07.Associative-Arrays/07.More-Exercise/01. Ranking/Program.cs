using System;
using System.Collections.Generic;
using System.Linq;


namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestDict = new Dictionary<string, string>();
            List<Student> studentList = new List<Student>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = input.Split(':');
                string contest = tokens[0];
                string password = tokens[1];

                contestDict.Add(contest, password);
            }

            input = string.Empty;
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = input.Split("=>");

                string contest = tokens[0];
                string password = tokens[1];
                string name = tokens[2];
                int points = int.Parse(tokens[3]);

                if (!contestDict.ContainsKey(contest) || contestDict[contest] != password)
                {
                    continue;
                }

                if (!(studentList.Any(x => x.Name == name && x.Contest == contest)))
                {
                    studentList.Add(new Student(name, contest, points));
                }

                else
                {
                    int currStudentIndex = studentList.FindIndex(x => x.Name == name && x.Contest == contest);
                    if (studentList[currStudentIndex].Points < points)
                    {
                        studentList[currStudentIndex].Points = points;
                    }
                }
            }

            var bestStudent = studentList
                .GroupBy(x => x.Name)
                .Select(group => new
                {
                    Name = group.Key,
                    SumOfPoints = group.Sum(x => x.Points)
                })
                .ToArray()
                .OrderByDescending(x => x.SumOfPoints)
                .First();

            Console.WriteLine($"Best candidate is {bestStudent.Name} with total {bestStudent.SumOfPoints} points.");
            Console.WriteLine("Ranking: ");

            var groupStudents = studentList
                .OrderBy(x => x.Name)
                .GroupBy(x => x.Name);

            foreach (var item in groupStudents)
            {
                Console.WriteLine(item.Key);

                foreach (Student student in studentList
                    .Where(x => x.Name == item.Key)
                    .OrderBy(x => x.Name)
                    .ThenByDescending(x => x.Points))
                    Console.WriteLine($"#  {student.Contest} -> {student.Points}");
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Contest { get; set; }
        public int Points { get; set; }
        public Student(string name, string contest, int points)
        {
            Name = name;
            Contest = contest;
            Points = points;
        }

    }
}

/* Here comes the final and the most interesting part – the Final ranking of the candidate-interns. 
 * The final ranking is determined by the points of the interview tasks and from the exams in SoftUni. 
 * Here is your final task. You will receive some lines of input in the format "{contest}:{password for contest}", 
 * until you receive "end of contests". Save that data, because you will need it later. 
 * After that, you will receive another type of input in the format "{contest}=>{password}=>{username}=>{points}" 
 * until you receive "end of submissions". Here is what you need to do:
 * •	Check if the contest is valid (if you received it in the first type of input).
 * •	Check if the password is correct for the given contest.
 * •	Save the user with the contest they take part in (a user can take part in many contests) and the points the user has in the given contest. 
 * If you receive the same contest and the same user, update the points, only if the new ones are more than the older ones.
 * In the end, you have to print the info for the user with the most points 
 * in the format "Best candidate is {user} with total {total points} points.". 
 * After that print all students ordered by their names. For each user print each contest with the points in descending order. 
 * See the examples.
 * 
 * Input
 * •	Strings in format "{contest}:{password for contest}" until the "end of contests" command. 
 * There will be no case with two equal contests.
 * •	Strings in format "{contest}=>{password}=>{username}=>{points}", until the "end of submissions" command.
 * •	There will be no case with 2 or more users with the same total points!
 * 
 * Output
 * •	On the first line, print the best user in format "Best candidate is {user} with total {total points} points.". 
 * •	Then print all students, ordered as mentioned above, in format:
 * "{user1 name}"
 * "#  {contest1} -> {points}"
 * "#  {contest2} -> {points}"
 * 
 * Constraints
 * •	The strings may contain any ASCII character except ':', ' =', '>'.
 * •	The numbers will be in range [0…10000].
 * •	Second input is always valid.
 * 
 * Examples
 * 
 * INPUT
 * Part One Interview:success
 * Js Fundamentals:Jsfundmpass
 * C# Fundamentals:fundPass
 * Algorithms:fun
 * end of contests
 * C# Fundamentals=>fundPass=>Tanya=>350
 * Algorithms=>fun=>Tanya=>380
 * Part One Interview=>success=>Nikola=>120
 * Java Basics Exam=>jsfundmpass=>Mary=>400
 * Part One Interview=>success=>Tanya=>220
 * OOP Advanced=>password123=>Jim=>231
 * C# Fundamentals=>fundPass=>Tanya=>250
 * C# Fundamentals=>fundPass=>Nikola=>200
 * Js Fundamentals=>Jsfundmpass=>Tanya=>400
 * end of submissions
 * 
 * OUTPUT
 * Best candidate is Tanya with total 1350 points.
 * Ranking: 
 * Nikola
 * #  C# Fundamentals -> 200
 * #  Part One Interview -> 120
 * Tanya
 * #  Js Fundamentals -> 400
 * #  Algorithms -> 380
 * #  C# Fundamentals -> 350
 * #  Part One Interview -> 220
 * 
 * 
 * INPUT
 * Java Advanced:funpass
 * Part Two Interview:success
 * Math Concept:asdasd
 * Java Web Basics:forrF
 * end of contests
 * Math Concept=>ispass=>Mona=>290
 * Java Advanced=>funpass=>Simon=>400
 * Part Two Interview=>success=>Derek=>120
 * Java Advanced=>funpass=>Peter=>90
 * Java Web Basics=>forrF=>Simon=>280
 * Part Two Interview=>success=>Peter=>0
 * Math Concept=>asdasd=>Derek=>250
 * Part Two Interview=>success=>Simon=>200
 * end of submissions
 * 
 * OUTPUT
 * Best candidate is Simon with total 880 points.
 * Ranking: 
 * Derek
 * #  Math Concept -> 250
 * #  Part Two Interview -> 120
 * Peter
 * #  Java Advanced -> 90
 * #  Part Two Interview -> 0
 * Simon
 * #  Java Advanced -> 400
 * #  Java Web Basics -> 280
 * #  Part Two Interview -> 200
 * 
 */

