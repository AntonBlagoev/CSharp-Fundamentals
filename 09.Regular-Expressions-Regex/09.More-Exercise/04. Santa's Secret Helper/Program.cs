using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int decryptKey = int.Parse(Console.ReadLine());

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                StringBuilder decryptedInput = new StringBuilder();
                foreach (var letter in input)
                {
                    char currentLetter = (char)(letter - decryptKey);
                    decryptedInput.Append(currentLetter);
                }
                string pattern = @"[^@\-!\:\>]*?(@([A-Za-z]+))[^@\-!\:\>]+!([G])!";

                Match matchedNames = Regex.Match(decryptedInput.ToString(), pattern);
                string name = matchedNames.Groups[2].Value;

                if (matchedNames.Success)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}

/* After the successful second Christmas, Santa needs to gather information about the behavior of children to plan the presents for next Christmas.
 * He has a secret helper, who is sending him encrypted information. Your task is to decrypt it and create a list of the good children. 
 * You will receive an integer, which represents a key, and afterward some messages, 
 * which you must decode by subtracting the key from the value of each character. 
 * After the decryption, to be considered a valid match, a message should:
 * -	Have a name, which starts after '@' and contains only letters from the Latin alphabet.
 * -	Have a behavior type - "G"(good) or "N"(naughty) and must be surrounded by "!" (exclamation mark).
 * The order in the message should be the child's name -> child's behavior. 
 * They can be separated from the others by any character except '@', '-', '!', ':' and '>'. 
 * You will be receiving messages until you are given the “end” command. 
 * Afterward, print the names of the children, who will receive a present, each on a new line. 
 * 
 * Input / Constraints
 * •	The first line holds n – the number which you have to subtract from the characters – integer in the range [1…100].
 * •	On the next lines you will be receiving encrypted messages.
 * 
 * Output
 * Print the names of the children, each on a new line.
 * 
 * 
 * INPUT
 * 3
 * CNdwhamigyenumje$J$
 * CEreelh-nmguuejn$J$
 * CVwdq&gnmjkvng$Q$
 * end
 * 
 * OUTPUT
 * Kate
 * Bobbie
 * 
 * COMMENT
 * We receive three messages and to decrypt them we use the key:
 * The first message has decryption key 3. So we subtract from each characters code 3 and we receive:
 * @Kate^jfdvbkrjgb!G!
 * @Bobbie*kjdrrbgk!G!
 * @Stan#dkjghskd!N!
 * They are all valid and they contain a child's name and behavior – G for good and N for naughty.
 * 
 * INPUT
 * 3
 * N}eideidmk$'(mnyenmCNlpamnin$J$
 * ddddkkkkmvkvmCFrqqru-nvevek$J$nmgievnge
 * ppqmkkkmnolmnnCEhq/vkievk$Q$
 * yyegiivoguCYdohqwlqh/kguimhk$J$
 * end
 * 
 * OUPUT
 * Kim
 * Connor
 * Valentine
 * 
 * COMMENT
 * We receive four messages.
 * They are with key 3:
 * Kzbfabfajh!$%jkvbkj@Kim^jkfk!G!
 * aaaahhhhjshsj@Connor*ksbsbh!G!kjdfbskdb
 * mmnjhhhjklijkk@Ben,shfbsh!N!
 * vvbdffsldr@Valentine,hdrfjeh!G!
 */
