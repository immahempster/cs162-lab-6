using System;

namespace CardClasses
{
    public class BlackjackHand : Hand
    {
        public BlackjackHand() : base() { }

        public BlackjackHand(Deck deck, int numCards) : base(deck, numCards) { }

        public bool HasAce
        {
            get
            {
                return cards.Any(card => card.Value == 1);
            }
        }

        public int Score
        {
            get
            {
                int score = 0;
                bool aceAs11 = false;

                foreach (Card card in cards)
                {
                    if (card.Value > 10)
                    {
                        score += 10;
                    }
                    else if (card.Value == 1)
                    {
                        if (aceAs11)
                        {
                            score += 1;
                        }
                        else
                        {
                            score += 11;
                            aceAs11 = true;
                        }
                    }
                    else
                    {
                        score += card.Value;
                    }
                }

                return score;
            }
        }

        public bool IsBusted
        {
            get
            {
                return Score > 21;
            }
        }
    }
}