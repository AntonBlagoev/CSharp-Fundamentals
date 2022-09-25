using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                string userName = tokens[1];


                if (command == "register")
                {
                    string licensePlateNumber = tokens[2];

                    if (!parking.ContainsKey(userName))
                    {
                        parking.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }

                }
                else if (command == "unregister")
                {
                    if (parking.ContainsKey(userName))
                    {
                        parking.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
            }

            parking.ToList().ForEach(car => Console.WriteLine($"{car.Key} => {car.Value}"));

            //foreach (var user in parking)
            //{
            //    Console.WriteLine($"{user.Key} => {user.Value}");
            //}
        }
    }
}
/* 4.	SoftUni Parking
 * 
 * SoftUni just got a new parking lot. It's so fancy, it even has online parking validation. 
 * Except the online service doesn't work. It can only receive users' data, but it doesn't know what to do with it. 
 * Good thing you're on the dev team and know how to fix it, right?
 * Write a program, which validates a parking place for an online service. Users can register to park and unregister to leave.
 * The program receives 2 commands:	
 * 
 * •	"register {username} {licensePlateNumber}":
 * 
 *          o	The system only supports one car per user at the moment, so if a user tries to register another license plate, 
 *          using the same username, the system should print:
 *          * "ERROR: already registered with plate number {licensePlateNumber}"
 *      
 *          o	If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
 *          "{username} registered {licensePlateNumber} successfully"
 *          
 * •	"unregister {username}":
 * 
 *          o	If the user is not present in the database, the system should print:
 *          "ERROR: user {username} not found"
 *          
 *          o	If the aforementioned check passes successfully, the system should print:
 *          "{username} unregistered successfully"
 * After you execute all of the commands, print all of the currently registered users and their license plates in the format: 
 * •	"{username} => {licensePlateNumber}"
 * 
 * Input
 *  •	First line: n - number of commands – integer.
 *  •	Next n lines: commands in one of the two possible formats:
 *      o	Register: "register {username} {licensePlateNumber}"
 *      o	Unregister: "unregister {username}"
 * The input will always be valid and you do not need to check it explicitly.
 * 
 * 
 * Examples
 * -------------------------------------
 * Input
 * 5
 * register John CS1234JS
 * register George JAVA123S
 * register Andy AB4142CD
 * register Jesica VR1223EE
 * unregister Andy
 * 
 * Output
 * John registered CS1234JS successfully
 * George registered JAVA123S successfully
 * Andy registered AB4142CD successfully
 * Jesica registered VR1223EE successfully
 * Andy unregistered successfully
 * John => CS1234JS
 * George => JAVA123S
 * Jesica => VR1223EE
 * -------------------------------------
 * Input
 * 4
 * register Jony AA4132BB
 * register Jony AA4132BB
 * register Linda AA9999BB
 * unregister Jony
 * 
 * Output
 * Jony registered AA4132BB successfully
 * ERROR: already registered with plate number AA4132BB
 * Linda registered AA9999BB successfully
 * Jony unregistered successfully
 * Linda => AA9999BB
 * -------------------------------------
 * Input
 * 6
 * register Jacob MM1111XX
 * register Anthony AB1111XX
 * unregister Jacob
 * register Joshua DD1111XX
 * unregister Lily
 * register Samantha AA9999BB
 * 
 * Output
 * Jacob registered MM1111XX successfully
 * Anthony registered AB1111XX successfully
 * Jacob unregistered successfully
 * Joshua registered DD1111XX successfully
 * ERROR: user Lily not found
 * Samantha registered AA9999BB successfully
 * Joshua => DD1111XX
 * Anthony => AB1111XX
 * Samantha => AA9999BB
 * 
 * 
 */
