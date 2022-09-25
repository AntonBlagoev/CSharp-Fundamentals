using System;
using System.Collections.Generic;

namespace _03._Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordsDict = new Dictionary<string, List<string>>();
           
            // first Line

            string[] inputText = Console.ReadLine().Split(" | ");
            for (int i = 0; i < inputText.Length; i++)
            {
                string[] wordsAndDefinitions = inputText[i].Split(": ");
                string word = wordsAndDefinitions[0];
                string definition = wordsAndDefinitions[1];

                if (!wordsDict.ContainsKey(word))
                {
                    wordsDict.Add(word, new List<string>());
                    wordsDict[word].Add(definition);
                }

                else if (!wordsDict[word].Contains(definition))
                {
                    wordsDict[word].Add(definition);
                }
            }

            // second Line

            List<string> teacherList = new List<string>();

            string[] inputTeacherWords = Console.ReadLine().Split(" | ");
            foreach (var item in inputTeacherWords)
            {
                teacherList.Add(item);
            }

            // third Line

            string command = Console.ReadLine();

            if (command == "Hand Over")
            {
                Console.WriteLine(string.Join(" ", wordsDict.Keys));
            }
            else
            {
                foreach (var word in teacherList)
                {
                    if (wordsDict.ContainsKey(word))
                    {
                        Console.WriteLine($"{word}:");
                        foreach (var def in wordsDict[word])
                        {
                            Console.WriteLine($" -{def}");
                        }
                    }
                }
            }
        }
    }
}
