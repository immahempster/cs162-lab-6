using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Deck deck = new Deck();
        deck.Shuffle();

        Hand hand = new Hand(deck, 5);

        Console.WriteLine("Initial hand:");
        Console.WriteLine(hand.ToString());

        Card discardedCard = hand.DiscardCard(0);
        Console.WriteLine($"Discarded card: {discardedCard}");

        Console.WriteLine("Hand after discarding card:");
        Console.WriteLine(hand.ToString());

        Card newCard = new Card(1, 1);
        hand.AddCard(newCard);
        Console.WriteLine("Hand after adding new card:");
        Console.WriteLine(hand.ToString());

        Console.WriteLine($"Contains card {newCard}: {hand.Contains(newCard)}");
        Console.WriteLine($"Contains value 1 and suit 1: {hand.Contains(1, 1)}");
        Console.WriteLine($"Contains value 1: {hand.Contains(1)}");

        Console.WriteLine($"Index of card {newCard}: {hand.IndexOf(newCard)}");
        Console.WriteLine($"Index of value 1 and suit 1: {hand.IndexOf(1, 1)}");
        Console.WriteLine($"Index of value 1: {hand.IndexOf(1)}");
    }
}