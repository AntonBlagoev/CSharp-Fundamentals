using System;
using System.Collections.Generic;
using System.Linq;


namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(" -> ");

                if (commands[0] == "End")
                {
                    break;
                }

                string companyName = commands[0];
                string employeeId = commands[1];
                
                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }

                if (companies[companyName].Contains(employeeId))
                {
                    continue;
                }

                companies[companyName].Add(employeeId);
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employeeId in company.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }

                //for (int i = 0; i < item.Value.Count; i++)
                //{
                //    Console.WriteLine($"-- {item.Value[i]}");
                //}

            }
        }
    }
}
/* 7.	Company Users
 * 
 * Create a program that keeps information about companies and their employees. 
 * You will be receiving a company name and an employee's id, until you receive the "End" command. 
 * Add each employee to the given company. Keep in mind that a company cannot have two employees with the same id.
 * When you finish reading the data, print the company's name and each employee's id in the following format:
 * {companyName}
 * -- {id1}
 * -- {id2}
 * -- {idN}
 * 
 * Input / Constraints
 * •	Until you receive the "End" command, you will be receiving input in the format: "{companyName} -> {employeeId}".
 * •	The input always will be valid.
 * 
 * Examples
 * -------------------------------------
 * Input
 * SoftUni -> AA12345
 * SoftUni -> BB12345
 * Microsoft -> CC12345
 * HP -> BB12345
 * End
 * 
 * Output
 * SoftUni
 * -- AA12345
 * -- BB12345
 * Microsoft
 * -- CC12345
 * HP
 * -- BB12345
 * -------------------------------------
 * Input
 * SoftUni -> AA12345
 * SoftUni -> CC12344
 * Lenovo -> XX23456
 * SoftUni -> AA12345
 * Movement -> DD11111
 * End
 * 
 * Output
 * SoftUni
 * -- AA12345
 * -- CC12344
 * Lenovo
 * -- XX23456
 * Movement
 * -- DD11111
 * 
 * 
 */