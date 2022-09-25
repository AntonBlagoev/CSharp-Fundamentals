using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string inputText = Console.ReadLine();

                int startIndexForName = inputText.IndexOf('@') + 1;
                int endIndexForName = inputText.IndexOf('|');

                int startIndexForAge = inputText.IndexOf('#') + 1;
                int endIndexForAge = inputText.IndexOf('*') ;

                string name = inputText.Substring(startIndexForName, endIndexForName - startIndexForName);
                string age = inputText.Substring(startIndexForAge, endIndexForAge - startIndexForAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}

/* Create a program that reads N lines of strings and extracts the name and age of a given person.
 * The name of the person will be between '@' and '|'. The person's age will be between '#' and '*'.
 * Example: "Hello my name is @Peter| and I am #20* years old." 
 * For each found name and age print a line in the following format "{name} is {age} years old."
 * 
 * Input
 * 2
 * Here is a name @George| and an age #18*
 * Another name @Billy| #35* is his age
 * Output
 * George is 18 years old.
 * Billy is 35 years old.
 * 
 * Input
 * 3
 * random name @lilly| random digits #5* age
 * @Marry| with age #19*
 * here Comes @Garry| he is #48* years old
 * Output
 * lilly is 5 years old.
 * Marry is 19 years old.
 * Garry is 48 years old.
 *  
 */