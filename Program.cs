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
            //Creating a new deck. Check with Greg later about how to go about this. 

            var deck = new Queue<string>();
            deck.Enqueue("2 of Spades");
            deck.Enqueue("3 of Spades");
            deck.Enqueue("4 of Spades");
            deck.Enqueue("5 of Spades");
            deck.Enqueue("6 of Spades");
            deck.Enqueue("7 of Spades");
            deck.Enqueue("8 of Spades");
            deck.Enqueue("9 of Spades");
            deck.Enqueue("10 of Spades");
            deck.Enqueue("Jack of Spades");
            deck.Enqueue("Queen of Spades");
            deck.Enqueue("King of Spades");
            deck.Enqueue("Ace of Spades");
            deck.Enqueue("2 of Hearts");
            deck.Enqueue("3 of Hearts");
            deck.Enqueue("4 of Hearts");
            deck.Enqueue("5 of Hearts");
            deck.Enqueue("6 of Hearts");
            deck.Enqueue("7 of Hearts");
            deck.Enqueue("8 of Hearts");
            deck.Enqueue("9 of Hearts");
            deck.Enqueue("10 of Hearts");
            deck.Enqueue("Jack of Hearts");
            deck.Enqueue("Queen of Hearts");
            deck.Enqueue("King of Hearts");
            deck.Enqueue("Ace of Hearts");
            deck.Enqueue("2 of Diamonds");
            deck.Enqueue("3 of Diamonds");
            deck.Enqueue("4 of Diamonds");
            deck.Enqueue("5 of Diamonds");
            deck.Enqueue("6 of Diamonds");
            deck.Enqueue("7 of Diamonds");
            deck.Enqueue("8 of Diamonds");
            deck.Enqueue("9 of Diamonds");
            deck.Enqueue("10 of Diamonds");
            deck.Enqueue("Jack of Diamonds");
            deck.Enqueue("Queen of Diamonds");
            deck.Enqueue("King of Diamonds");
            deck.Enqueue("Ace of Diamonds");
            deck.Enqueue("2 of Clubs");
            deck.Enqueue("3 of Clubs");
            deck.Enqueue("4 of Clubs");
            deck.Enqueue("5 of Clubs");
            deck.Enqueue("6 of Clubs");
            deck.Enqueue("7 of Clubs");
            deck.Enqueue("8 of Clubs");
            deck.Enqueue("9 of Clubs");
            deck.Enqueue("10 of Clubs");
            deck.Enqueue("Jack of Clubs");
            deck.Enqueue("Queen of Clubs");
            deck.Enqueue("King of Clubs");
            deck.Enqueue("Ace of Clubs");


            //After deck creation, you should shuffle the deck.
            //Ask Greg about this foreach here, little confusing
            var random = new Random();
            var shuffledCards = deck.OrderBy(cards => random.Next());
            foreach (var card in shuffledCards)
            {
                Console.WriteLine($"{card}");

            }








            //After deck is shuffled, display top two cards.




            //ADVENTURE MODE
            //In  to displaying the top two cards, also store these 
            //two 'dealt' cards in a variable named playerHand. Consider the type of 
            //variable the playerHand will be.
            //Implement a way to deal cards to two different hands.

            //EPIC MODE
            //Implement the game of WAR
        }
    }
}

/* Gavin's psudo code help guide
numberOfCards = length of our deck
for rightIndex from numberOfCards - 1 down to 1 do:
leftIndex = random integer that is >= to 0 and LESS than rightIndex. 
see the section "How do we get a random integer"

Now swap values at rightIndex and leftIndex by doing this:
leftCard = the value from the deck (leftIndex)
rightCard = the value from the deck (right index)
deck[rightIndex] = leftCard
deck[leftIndex] = rightCard

*/


