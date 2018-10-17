using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeckCollections.Classes
{
    class Card
    {
        public Suit Suit { get; set; }
        public string Type { get; set; }

        public Card(Suit suit, string type)
        {
            Suit = suit;
            Type = type;
        }
    }

    enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }
}
