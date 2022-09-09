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
                "♠️", "♥️", "♦️", "♣️"
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
                Console.WriteLine(item.face + " " + item.suit + " " + " and it's value is " + item.point);
            }

            //After deck is shuffled, display top two cards.
            var twoCardsRemoval = new List<Card>();
            TopTwoCards(deck, twoCardsRemoval);

            Console.WriteLine("The first card from the deck is " + String.Join(" ", twoCardsRemoval[0].face, twoCardsRemoval[0].suit));
            Console.WriteLine("The second card from the deck is " + String.Join(" ", twoCardsRemoval[1].face, twoCardsRemoval[1].suit));
        }

        static (List<Card>, List<Card>) TopTwoCards(List<Card> playerDeck, List<Card> emptyDeck)
        {
            emptyDeck.Add(playerDeck[0]);
            playerDeck.RemoveAt(0);

            emptyDeck.Add(playerDeck[0]);
            playerDeck.RemoveAt(0);
            return (playerDeck, emptyDeck);
        }
    }
}


