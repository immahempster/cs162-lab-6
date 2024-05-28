using System;

namespace CardClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new deck
            Deck deck = new Deck();

            // Shuffle the deck
            deck.Shuffle();

            // Create a new blackjack hand
            BlackjackHand hand = new BlackjackHand();

            // Deal two cards to the hand
            hand.AddCard(deck.Deal());
            hand.AddCard(deck.Deal());

            // Print the hand
            Console.WriteLine(hand.ToString());

            // Check if the hand has an ace
            Console.WriteLine("Has Ace: " + hand.HasAce);

            // Get the score of the hand
            Console.WriteLine("Score: " + hand.Score);

            // Check if the hand is busted
            Console.WriteLine("Is Busted: " + hand.IsBusted);

            // Deal another card to the hand
            hand.AddCard(deck.Deal());

            // Print the hand again
            Console.WriteLine(hand.ToString());

            // Check if the hand has an ace again
            Console.WriteLine("Has Ace: " + hand.HasAce);

            // Get the score of the hand again
            Console.WriteLine("Score: " + hand.Score);

            // Check if the hand is busted again
            Console.WriteLine("Is Busted: " + hand.IsBusted);
        }
    }
}