using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string department = input[2];
                employees.Add(new Employee(name, salary, department));
            }

            var groupedDepartments = employees
                .GroupBy(x => x.Department)
                .Select(group => new
                {
                    Department = group.Key,
                    AverageSalary = group.Average(x => x.Salary)
                })
                .ToArray()
                .OrderByDescending(x => x.AverageSalary)
                .First()
                .Department;

            Console.WriteLine($"Highest Average Salary: {groupedDepartments}");

            employees
            .Where(x => x.Department == groupedDepartments)
            .OrderByDescending(x => x.Salary)
            .ToList()
            .ForEach(Console.WriteLine);


        }


        class Employee
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public string Department { get; set; }
            public Employee(string name, decimal salary, string department)
            {
                Name = name;
                Salary = salary;
                Department = department;
            }
            public override string ToString()
            {
                return $"{Name} {Salary:f2}";
            }
        }
    }
}
/* Define a class Employee that holds the following information: a name, a salary and a department. 
 * Your task is to write a program, which takes N lines of employees from the console, 
 * calculates the department with the highest average salary, 
 * and prints for each employee in that department their name and salary – sorted by salary in descending order. 
 * The salary should be rounded to two digits after the decimal separator.
 * 
 * INPUT
 * 4
 * Peter 120.00 Development
 * Tony 333.33 Marketing
 * Jony 840.20 Development
 * George 0.20 Nowhere
 * 
 * OUTPUT
 * Highest Average Salary: Development
 * Jony 840.20
 * Peter 120.00
 * 
 * INPUT
 * 6
 * Suny 496.37 Coding
 * Johny 610.13 Sales
 * Teo 609.99 Sales
 * Vlady 0.02 BeerDrinking
 * Andrey 700.00 Coding
 * Popeye 13.3333 SpinachGroup
 * 
 * OUTPUT
 * Highest Average Salary: Sales
 * Johny 610.13
 * Teo 609.99
 * 
 */