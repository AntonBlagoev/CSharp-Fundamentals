using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace _03._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            Match firstPart = Regex.Match(input[0], @"(?<separator>[#$%*&])([A-Z]+)(\k<separator>)");

            string firstPartWord = firstPart.Groups[1].Value;

            foreach (var letter in firstPartWord)
            {
                char currLetter = char.Parse(letter.ToString());
                int letterASCII = currLetter;

                Match secondPart = Regex.Match(input[1], @$"({letterASCII}):([0-9][0-9])");
                int secondPartRightDigits = int.Parse(secondPart.Groups[2].Value);
                int wordLenght = secondPartRightDigits + 1;

                string wordFounded = new List<string>(input[2].Split(' '))
                    .Find(x => x.ToString().Substring(0, 1) == letter.ToString() && x.ToString().Length == secondPartRightDigits + 1);

                Console.WriteLine(wordFounded);

            }
        }
    }
}
/* You read a single line of ASCII symbols and the message is somewhere inside it, you must find it.
 * The input consists of three parts separated with "|" like this:
 * "{firstPart}|{secondPart}|{thirdPart}"
 * Each word starts with a capital letter and has a fixed length, you can find those in each different part of the input.
 * The first part carries the capital letters for each word inside the message. 
 * You need to find those capital letters 1 or more from A to Z. 
 * The capital letters should be surrounded from both sides with any of the following symbols – "#, $, %, *, &". 
 * And those symbols should match on both sides. This means that $AOTP$ - is a valid pattern for the capital letters. 
 * $AKTP% - is invalid since the symbols do not match.
 * The second part of the data contains the starting letter ASCII code and words length /between 1 – 20 characters/, 
 * in the following format: "{asciiCode}:{length}". For example, "67:05" – means that "67" - ASCII code equal to the capital letter "C", 
 * represents a word starting with "C" with the following 5 characters: like "Carrot". 
 * The ASCII code should be a capital letter equal to a letter from the first part. 
 * Word's length should be exactly 2 digits. Length less than 10 will always have a padding zero, you don't need to check that. 
 * The third part of the message are words separated by spaces. 
 * Those words have to start with the Capital letter [A…Z] equal to the ASCII code and 
 * have exactly the length for each capital letter you have found in the second part. 
 * Those words can contain any ASCII symbol without spaces.
 * When you find a valid word, you have to print it on a new line. 
 * 
 * Input / Constraints
 * •	On the first line – the text is in form of three different parts separated by "|". 
 * There can be any ASCII character inside the input, except '|'.
 * •	Input will always be valid - you don't need to check it.
 * •	The input will always have three different parts, that will always be separated by '|'.
 * 
 * Output
 * •	Print all extracted words, each on a new line.
 * •	Allowed working time / memory: 100ms / 16MB.
 * 
 * 
 * INPUT
 * sdsGGasAOTPWEEEdas$AOTP$|a65:1.2s65:03d79:01ds84:02! -80:07++ABs90:1.1|adsaArmyd Gara So La Arm Armyw21 Argo O daOfa Or Ti Sar saTheww The Parahaos
 * 
 * OUTPUT
 * Argo
 * Or
 * The
 * Parahaos
 * 
 * COMMENT
 * The capital letters are "AOTP"
 * Then we look for the addition length of the words for each capital letter. 
 * For A(65) -> it's 4. For O(79) -> it's 2. For T(84) -> it's 3. For P(80) -> it's 8.
 * Then we search in the last part for the words. First, start with the letter 'A' and we find "Argo". 
 * With the letter 'O' we find  "Or". With the letter 'T' we find "The" and with the letter 'P' we find "Parahaos".
 * 
 * INPUT
 * Urgent"Message.TO$#POAML#|readData79:05:79:0!2reme80:03--23:11{79:05}tak{65:11ar}!77:!23--)77:05ACCSS76:05ad|Remedy Por Ostream :Istream Post sOffices Office Of Ankh-Morpork MR.LIPWIG Mister Lipwig
 * 
 * OUTPUT
 * Post
 * Office
 * Ankh-Morpork
 * Mister
 * Lipwig
 * 
 * COMMENT
 * The first capital letters are "POAML"
 * Then we look for the additional length of the words for each capital letter. 
 * P(80) -> it's 4.
 * O(79) -> it's 6.
 * A(65) -> it's 12.
 * M(77) -> it's 6.
 * L(76) -> it's 6.
 * Then we search the last part for the words. First, start with the letter 'P' and we find "Post".
 * With the letter 'O' we find "Office". With the letter 'A' we find "Ankh-Morpork". 
 * With the letter 'M' we find "Mister" and with the letter 'L' we find "Lipwig". 
 * 
 * 
 */