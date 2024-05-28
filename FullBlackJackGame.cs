using System;

namespace CardClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new deck
            Deck deck = new Deck();

            // Create two blackjack hands, one for the player and one for the dealer
            BlackjackHand playerHand = new BlackjackHand();
            BlackjackHand dealerHand = new BlackjackHand();

            // Initialize the number of hands won by the player and the dealer
            int playerWins = 0;
            int dealerWins = 0;

            // Loop until the user decides to quit
            while (true)
            {
                // Shuffle the deck
                deck.Shuffle();

                // Deal two cards to the player and two cards to the dealer
                playerHand.AddCard(deck.Deal());
                playerHand.AddCard(deck.Deal());
                dealerHand.AddCard(deck.Deal());
                dealerHand.AddCard(deck.Deal());

                // Print the initial hands
                Console.WriteLine("Player's hand: " + playerHand.ToString());
                Console.WriteLine("Dealer's hand: " + dealerHand.ToString());

                // Loop until the player decides to stand
                while (true)
                {
                    // Ask the player if they want to hit or stand
                    Console.WriteLine("Do you want to hit or stand? (H/S)");
                    string input = Console.ReadLine();

                    // Validate the input
                    if (input.ToLower() == "h")
                    {
                        // Deal another card to the player
                        playerHand.AddCard(deck.Deal());
                        Console.WriteLine("Player's hand: " + playerHand.ToString());

                        // Check if the player is busted
                        if (playerHand.IsBusted)
                        {
                            Console.WriteLine("Player is busted! Dealer wins!");
                            dealerWins++;
                            break;
                        }
                    }
                    else if (input.ToLower() == "s")
                    {
                        // Stand, break out of the loop
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter H or S.");
                    }
                }

                // Dealer's turn
                while (dealerHand.Score < 17)
                {
                    // Deal another card to the dealer
                    dealerHand.AddCard(deck.Deal());
                }

                // Print the final hands
                Console.WriteLine("Player's hand: " + playerHand.ToString());
                Console.WriteLine("Dealer's hand: " + dealerHand.ToString());

                // Determine the winner
                if (playerHand.Score > dealerHand.Score || dealerHand.IsBusted)
                {
                    Console.WriteLine("Player wins!");
                    playerWins++;
                }
                else if (playerHand.Score < dealerHand.Score)
                {
                    Console.WriteLine("Dealer wins!");
                    dealerWins++;
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }

                // Ask the user if they want to play again
                Console.WriteLine("Do you want to play again? (Y/N)");
                string input = Console.ReadLine();

                // Validate the input
                if (input.ToLower() != "y")
                {
                    break;
                }
            }

            // Print the final score
            Console.WriteLine("Player wins: " + playerWins);
            Console.WriteLine("Dealer wins: " + dealerWins);
        }
    }
}