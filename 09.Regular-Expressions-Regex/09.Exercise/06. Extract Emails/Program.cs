using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\s([a-z0-9]+[\.\-_]?\w+[@]\w+[\.\-]?\w+\.?\w+\.\w+)";      //@" ([a-z0-9]+[\.\-_]?\w+[@]\w+[\.\-]?\w+\.?\w+\.\w+)"
            MatchCollection validMails = Regex.Matches(input, pattern);                   //@"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)+\b"
            validMails.ToList().ForEach(Console.WriteLine);                                          

            //foreach (var mail in validMails)
            //{
            //    Console.WriteLine(mail);      //Console.WriteLine(mail.ToString().Trim());
            //}
        }
    }
}

/* Write a program to extract all email addresses from a given text. 
 * The text comes at the only input line. Print the emails on the console, each at a separate line. 
 * 
 * Emails are considered to be in format <user>@<host>, where: 
 * •	<user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them.
 * o	Examples of valid users: "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345".
 * o	Examples of invalid users: ''--123", "……", "nakov_-", "_steve", ".info". 
 * •	<host> is a sequence of at least two words, separated by dots '.'. 
 * 
 * Each word is a sequence of letters and can have hyphens '-' between the letters.
 * o	Examples of hosts: "softuni.bg", "software-university.com", "intoprogramming.info", "mail.softuni.org". 
 * o	Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-".
 * 
 * •	Examples of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy.
 * 
 * •	Examples of invalid emails: --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld, mike@.unknown.soft., s.johnson@invalid-.
 * 
 * 
 * INPUT
 * Please contact us at: support@github.com.
 * 
 * OUTPUT
 * support@github.com
 * 
 * INPUT
 * Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.
 * 
 * OUTPUT
 * s.miller@mit.edu
 * j.hopking@york.ac.uk
 * 
 */
