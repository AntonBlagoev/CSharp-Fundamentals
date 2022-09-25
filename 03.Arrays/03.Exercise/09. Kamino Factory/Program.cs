using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSequences = int.Parse(Console.ReadLine());
            string sequenceInputString = Console.ReadLine();
            int[] bestSequence = new int[lengthOfSequences];
            int bestSequenceCount = -1;
            int bestSequenceCycle = 1;
            int bestStartIndex = int.MaxValue;
            int countOfCycles = 0;
            int bestSumOfOnes = 0;

            while (sequenceInputString != "Clone them!")
            {
                int[] sequence = sequenceInputString.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                countOfCycles++;
                int countOfOnesSequence = 0;
                int countOfOnes = 0;
                int startIndex = int.MaxValue;
                int currentSumOfOnes = 0;
                bool bestDNA = false;

                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == 1)
                    {
                        countOfOnes++;
                        if (countOfOnes == 2)
                        {
                            countOfOnesSequence++;
                            if (startIndex == int.MaxValue)
                            {
                                startIndex = i - 1;
                            }
                        }
                        else
                        {
                            countOfOnes = 1;
                        }
                    }
                    else
                    {
                        countOfOnes = 0;
                    }   
                }
                currentSumOfOnes = sequence.Sum();
                if (countOfOnesSequence >= bestSequenceCount)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestDNA = true;
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSumOfOnes > bestSumOfOnes)
                        {
                            bestDNA = true;
                        }
                    }
                }
                if (bestDNA)
                {
                    bestSequenceCount = countOfOnesSequence;
                    bestSequenceCycle = countOfCycles;
                    bestStartIndex = startIndex;
                    bestSequence = sequence;
                    bestSumOfOnes = currentSumOfOnes;
                }
                sequenceInputString = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSequenceCycle} with sum: {bestSumOfOnes}.");
            Console.WriteLine(string.Join(" ", bestSequence));

        }
    }
}
