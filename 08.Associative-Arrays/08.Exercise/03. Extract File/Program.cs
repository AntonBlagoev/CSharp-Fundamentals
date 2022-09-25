using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            int indexOfBackslash = inputText.LastIndexOf('\\');
            int indexOfPoint = inputText.IndexOf('.');

            string fileName = inputText.Substring(indexOfBackslash + 1, indexOfPoint - indexOfBackslash - 1);
            string fileExtension = inputText.Substring(indexOfPoint + 1, inputText.Length - indexOfPoint - 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}

/* Create a program that reads the path to a file and subtracts the file name and its extension.
 * 
 * Input
 * C:\Internal\training-internal\Template.pptx
 * Output
 * File name: Template
 * File extension: pptx
 * 
 * Input
 * C:\Projects\Data-Structures\LinkedList.cs
 * Output
 * File name: LinkedList
 * File extension: cs 
 * 
 */