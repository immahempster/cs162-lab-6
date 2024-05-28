using System;
using System.Collections.Generic;

namespace CardClasses
{
    public class Hand : Deck
    {
        public Hand() { }

        public Hand(Deck deck, int numCards) : base()
        {
            for (int i = 0; i < numCards; i++)
            {
                AddCard(deck.Deal());
            }
        }

        public int NumCards
        {
            get { return cards.Count; }
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public Card DiscardCard(int index)
        {
            Card card = cards[index];
            cards.RemoveAt(index);
            return card;
        }

        public Card GetCard(int index)
        {
            return cards[index];
        }

        public bool Contains(Card card)
        {
            return cards.Contains(card);
        }

        public bool Contains(int value, int suit)
        {
            return cards.Any(c => c.Value == value && c.Suit == suit);
        }

        public bool Contains(int value)
        {
            return cards.Any(c => c.Value == value);
        }

        public int IndexOf(Card card)
        {
            return cards.IndexOf(card);
        }

        public int IndexOf(int value, int suit)
        {
            return cards.FindIndex(c => c.Value == value && c.Suit == suit);
        }

        public int IndexOf(int value)
        {
            return cards.FindIndex(c => c.Value == value);
        }

        public override string ToString()
        {
            string output = "";
            foreach (Card card in cards)
            {
                output += card.ToString() + "\n";
            }
            return output;
        }
    }
}