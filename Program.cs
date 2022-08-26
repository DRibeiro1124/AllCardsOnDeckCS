using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Card
    {
        public string suit;
        public string face;
        // public int point;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //EXPLORER MODE
            //Once the program starts, you should create a new deck of cards.
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

                    // if face != J K Q A 
                    // parse the number string 
                    // else if it == J K Q A 
                    // if J 
                    // point = 11
                    // else if Q
                    // point = 12 
                    // and so on
                    Card singleCard = new Card { suit = suit, face = rankings };
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
                Console.WriteLine(item.face + " " + item.suit);
            }

            //After deck is shuffled, display top two cards.
            var topOfDeck = deck[0].face + deck[0].suit + " " + " and " + deck[1].face + deck[1].suit;
            Console.WriteLine($"The top two cards from the deck are {topOfDeck}");

            // ADVENTURE MODE
            //In addition to displaying the top two cards, also store these
            //two "dealt" cards in a variable named playerHand. 
            //Consider what type of variable playerHand will have to be.



            //Implement a way to two deal cards each into two different hands.
            // var firstDealtCard = deck[0].face + deck[0].suit + deck.face[1] + deck.suit[1];


            //EPIC MODE
            //Implement the game of WAR
            var playerOneDeck = deck.Where((x, i) => i % 2 == 0);
            var playerTwoDeck = deck.Where((x, i) => i % 2 != 0);

            //Console.WriteLine($"Player One has these cards {string.Join(System.Environment.NewLine, playerOneDeck)}");
            //Console.WriteLine($"Player Two has these cards {string.Join(System.Environment.NewLine, playerTwoDeck)}");

            //Both Players should each have 26 cards. Now the game start

        }
        //create a new function outside of main to deal the cards out.
        //Passing in deck of cards and then passing in an empty array for user cards dealt.
        //Then return two list A- remainder of the deck B-the cards dealt

    }

}

