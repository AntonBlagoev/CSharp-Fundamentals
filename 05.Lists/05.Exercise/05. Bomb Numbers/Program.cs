using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = commands[0];
            int bombPower = commands[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int start = Math.Max(0, i - bombPower);
                    int end = Math.Min(numbers.Count - 1, i + bombPower);

                    for (int j = start; j <= end; j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }
            Console.WriteLine(numbers.Sum()); 
        }
    }
}
/* Create a program that reads a sequence of numbers and a special bomb number holding a certain power. 
 * Your task is to detonate every occurrence of the special bomb number and according to its power the numbers to its left and right. 
 * The bomb power refers to how many numbers to the left and right will be removed, no matter their values. 
 * Detonations are performed from left to right and all the detonated numbers disappear. 
 * Finally, print the sum of the remaining elements in the sequence.
 * 
 * Examples
 * 
 * 
 * Input
 * 1 2 2 4 2 2 2 9
 * 4 2
 * 
 * Output
 * 12
 * 
 * Comments
 * The special number is 4 with power 2. After detonation, we are left with the sequence [1, 2, 9] with sum 12.
 * 
 * Input
 * 1 4 4 2 8 9 1
 * 9 3
 * 
 * Output
 * 5
 * 
 * Comments
 * The special number is 9 with power 3. After detonation, we are left with the sequence [1, 4] with sum 5. 
 * Since the 9 has only 1 neighbor from the right we remove just it (one number instead of 3). * 
 * 
 * Input
 * 1 7 7 1 2 3
 * 7 1
 * 
 * Output
 * 6
 * 
 * Comments
 * Detonations are performed from left to right. We cannot detonate the second occurrence of 7, because it's already destroyed by the first occurrence. 
 * The numbers [1, 2, 3] survive. Their sum is 6. 
 * 
 * Input
 * 1 1 2 1 1 1 2 1 1 1
 * 2 1
 * 
 * Output
 * 4
 * 
 * Comments
 * The red and yellow numbers disappear in two sequential detonations. The result is the sequence [1, 1, 1, 1]. Sum = 4.
 * 
 */