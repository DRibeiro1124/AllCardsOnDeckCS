using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace AllCardsOnDeckCS
{
    class Card
    {
        public string suit { get; set; }
        public string face { get; set; }
        public int point { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create a deck of cards
            var faceValue = new List<string>()
            {
                "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
            };

            var suits = new List<string>()
           {
                "♠️", "💚", "♦️", "♣️"
           };

            var deck = new List<Card>();

            foreach (var rankings in faceValue)
            {
                foreach (var suit in suits)
                {
                    var cardValue = 0;


                    if (rankings == "J")
                    {
                        cardValue = 11;
                    }
                    else if (rankings == "Q")
                    {
                        cardValue = 12;
                    }
                    else if (rankings == "K")
                    {
                        cardValue = 13;
                    }
                    else if (rankings == "A")
                    {
                        cardValue = 14;
                    }
                    else
                    {
                        cardValue = int.Parse(rankings);
                    }

                    Card singleCard = new Card { suit = suit, face = rankings, point = cardValue };
                    deck.Add(singleCard);
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

            foreach (var item in deck)
            {
                //display the whole shuffled deck
                Console.WriteLine(item.face + " " + item.suit + " " + " and their value is " + item.point);
            }

            //After deck is shuffled, display top two cards.
            var twoCardsRemoval = new List<Card>();
            TopTwoCard(deck, twoCardsRemoval);

            Console.WriteLine("The first card from the deck is " + String.Join(" ", twoCardsRemoval[0].face, twoCardsRemoval[0].suit));
            Console.WriteLine("The second card from the deck is " + String.Join(" ", twoCardsRemoval[1].face, twoCardsRemoval[1].suit));

            // ADVENTURE MODE
            //In addition to displaying the top two cards, also store these
            //two "dealt" cards in a variable named playerHand. 
            //Consider what type of variable playerHand will have to be.


            //Implement a way to two deal cards each into two different hands.


            //EPIC MODE
            //Implement the game of WAR
            // var playerOneDeck = deck.Where((x, i) => i % 2 == 0);
            // var playerTwoDeck = deck.Where((x, i) => i % 2 != 0);

            //Console.WriteLine($"Player One has these cards {string.Join(System.Environment.NewLine, playerOneDeck)}");
            //Console.WriteLine($"Player Two has these cards {string.Join(System.Environment.NewLine, playerTwoDeck)}");

            //Both Players should each have 26 cards. Now the game start

        }
        //create a new function outside of main to deal the cards out.
        static (List<Card>, List<Card>) TopTwoCard(List<Card> playerDeck, List<Card> emptyDeck)
        {

            // Console.WriteLine($"DECK {playerDeck.Count}");
            // Console.WriteLine($"EMPTY {emptyDeck.Count}");
            emptyDeck.Add(playerDeck[0]);
            playerDeck.RemoveAt(0);
            // Console.WriteLine($"DECK {playerDeck.Count}");
            // Console.WriteLine($"EMPTY{emptyDeck.Count}");

            // Console.WriteLine($"DECK {playerDeck.Count}");
            // Console.WriteLine($"EMPTY {emptyDeck.Count}");
            emptyDeck.Add(playerDeck[0]);
            playerDeck.RemoveAt(0);
            // Console.WriteLine($"DECK {playerDeck.Count}");
            // Console.WriteLine($"EMPTY{emptyDeck.Count}");

            return (playerDeck, emptyDeck);


        }
    }
}


