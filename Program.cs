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
            //Trying to create a dictionary to add value to each card in my deck
            var cardPoints = new Dictionary<int, string>()
            {
                {2, "2"}, {3, "3"}, {4, "4"}, {5, "5"}, {6, "6"}, {7,"7"}, {8, "8"},
                 {9, "9"}, {10, "10"}, {11, "J"}, {12, "Q"}, {13, "K"}, {14, "A"}
            };

            var suits = new List<string>()
           {
            "♠️", "💚", "♦️", "♣️"

           };

            var deck = new List<string>();

            var shuffle = new List<string>();
            foreach (KeyValuePair<int, string> cardValue in cardPoints)
            {
                foreach (var suit in suits)
                {
                    var card = $"{cardValue.Value} {suit}";
                    deck.Add(card);
                }
            }

            //After deck creation, you should shuffle the deck.

            var random = new Random();
            for (var i = deck.Count - 1; i > 0; i--)
            {
                var n = random.Next(i + 1);
                var tempi = deck[i];
                deck[i] = deck[n];
                deck[n] = tempi;
            };
            Console.WriteLine($"{string.Join(System.Environment.NewLine, deck)}");

            //Try and see the whole deck shuffled
            //I'm not 100% sure how this works but it fixed my error. Check with Greg


            //After deck is shuffled, display top two cards.

            Console.WriteLine($"The first two cards from the deck are {deck[0]}  and  {deck[1]}");

            // ADVENTURE MODE
            //In addition to displaying the top two cards, also store these
            //two "dealt" cards in a variable named playerHand. 
            //Consider what type of variable playerHand will have to be.

            var playerHand = deck[0] + "  and " + deck[1];
            var computerHand = deck[2] + "  and " + deck[3];


            //Implement a way to two deal cards each into two different hands.
            Console.WriteLine($"Player has been dealt {playerHand}");
            Console.WriteLine($"The Computer has been dealt {computerHand}");
            //This will have to be refactored because it's only taking the top
            //two cards from the deck but it doesn't removed them out of the deck.
            //Console.WriteLine($"There are now {deck.Count} cards in the deck");


            //EPIC MODE
            //Implement the game of WAR

        }

    }
}



