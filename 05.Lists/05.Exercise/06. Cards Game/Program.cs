using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondfPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                if (firstPlayerCards[0] > secondfPlayerCards[0])
                {
                    firstPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.Add(secondfPlayerCards[0]);
                }

                else if (firstPlayerCards[0] < secondfPlayerCards[0])
                {
                    secondfPlayerCards.Add(secondfPlayerCards[0]);
                    secondfPlayerCards.Add(firstPlayerCards[0]);
                }

                firstPlayerCards.Remove(firstPlayerCards[0]);
                secondfPlayerCards.Remove(secondfPlayerCards[0]);

                if (firstPlayerCards.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondfPlayerCards.Sum()}");
                    break;
                    
                }
                if (secondfPlayerCards.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
                    break;
                }
            }
        }
    }
}

/* You will be given two hands of cards, which will be represented by integers. 
 * Assume each one is held by a different player. You have to find which one has the winning deck. 
 * You start from the beginning of both hands of cards. Compare the cards from the first deck to the cards from the second deck. 
 * The player, who holds the more powerful card on the current iteration, 
 * takes both cards and puts them at the back of his hand - the second player's card is placed last 
 * and the first person's card (the winning one) comes after it (second to last). 
 * If both players' cards have the same values - no one wins and the two cards must be removed from both hands. 
 * The game is over only when one of the decks is left without any cards. 
 * You have to display the result on the console and the sum of the remaining cards: "{First/Second} player wins! Sum: {sum}".
 * 
 * Examples
 * 
 * Input
 * 20 30 40 50
 * 10 20 30 40
 * 
 * Output
 * First player wins! Sum: 240
 * 
 * Input
 * 10 20 30 40 50
 * 50 40 30 30 10
 * 
 * Output
 * Second player wins! Sum: 50
 * 
 */