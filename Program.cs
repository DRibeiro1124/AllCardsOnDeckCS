using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXPLORER MODE
            //Once the program starts, you should create a new deck of cards.

            var suits = new List<string>()
           {
            "Spades", "Hearts", "Diamonds", "Clubs"
           };

            var cardRanking = new List<string>()
            {
             "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"
            };

            var deck = new List<string>();


            foreach (var suit in suits)
            {
                foreach (var rank in cardRanking)
                {
                    var card = $"{rank} of {suit}";
                    deck.Add(card);
                }
            }


            //After deck creation, you should shuffle the deck.

            var random = new Random();
            for (var i = deck.Count - 1; i > 0; i--)
            {
                var n = random.Next(i + 1);
                var temp = deck[i];
                deck[i] = deck[n];
                deck[n] = temp;
            };

            //Try and see the whole deck shuffled
            //I'm not 100% sure how this works but it fixed my error. Check with Greg
            Console.WriteLine($"{string.Join(System.Environment.NewLine, deck)}");


            //After deck is shuffled, display top two cards.

            Console.WriteLine($"The first two cards from the deck are {deck[0]} and {deck[1]}");

            // ADVENTURE MODE
            //In addition to displaying the top two cards, also store these
            //two "dealt" cards in a variable named playerHand. 
            //Consider what type of variable playerHand will have to be.

            var playerFirstCard = deck[0];
            var playerSecondCard = deck[1];
            var cpuFirstCard = deck[2];
            var cpuSecondCard = deck[3];

            //Implement a way to two deal cards each into two different hands.
            Console.WriteLine($"Player has been dealt {playerFirstCard} and {playerSecondCard}");
            Console.WriteLine($"The Computer has been dealt {cpuFirstCard} and {cpuSecondCard}");

            //EPIC MODE
            //Implement the game of WAR
        }

    }
}




