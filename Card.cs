using System;

namespace CardClasses
{
    public class Card
    {
        private int value;
        private int suit;

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (value >= 1 && value <= 13)
                    this.value = value;
                else
                    throw new ArgumentException("Value must be between 1 and 13.");
            }
        }

        public int Suit
        {
            get
            {
                return suit;
            }
            set
            {
                if (value >= 1 && value <= 4)
                    this.suit = value;
                else
                    throw new ArgumentException("Suit must be between 1 and 4.");
            }
        }

        public Card() { }

        public Card(int value, int suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string[] values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };

            return $"{values[this.value - 1]} of {suits[this.suit - 1]}";
        }

        public bool IsRed
        {
            get
            {
                return this.suit == 2 || this.suit == 3;
            }
        }

        public bool IsBlack
        {
            get
            {
                return this.suit == 1 || this.suit == 4;
            }
        }

        public bool IsClub
        {
            get
            {
                return this.suit == 1;
            }
        }

        public bool IsDiamond
        {
            get
            {
                return this.suit == 2;
            }
        }

        public bool IsHeart
        {
            get
            {
                return this.suit == 3;
            }
        }

        public bool IsSpade
        {
            get
            {
                return this.suit == 4;
            }
        }

        public bool IsAce
        {
            get
            {
                return this.value == 1;
            }
        }

        public bool IsFaceCard
        {
            get
            {
                return this.value >= 11 && this.value <= 13;
            }
        }

        public bool MatchesSuit(Card other)
        {
            return this.suit == other.suit;
        }

        public bool MatchesValue(Card other)
        {
            return this.value == other.value;
        }
    }
}