using System;
using Xunit;
using CardDeckCollections.Classes;

namespace TestCardDeck
{
    public class UnitTest1
    {
        //Test add card to deck
        [Fact]
        public void AddToDeckSuccess()
        {
            Deck<Card> testDeck = new Deck<Card>();
            Card c1 = new Card(Suit.Hearts, "Q");
            testDeck.Add(c1);
            Assert.Equal(1, testDeck.count);
        }

        //Get Suit from Card
        [Fact]
        public void GetSuitFromCard()
        {
            Card c = new Card(Suit.Hearts, "Q");
            Assert.Equal(Suit.Hearts, c.Suit);
        }

        //Get Type from Card
        [Fact]
        public void GetTypeFromCard()
        {
            Card c = new Card(Suit.Hearts, "Q");
            Assert.Equal("Q", c.Type);
        }

        //Set Type for card
        [Fact]
        public void SetTypeForCard()
        {
            Card c = new Card(Suit.Diamonds, "K");
            c.Type = "J";
            Assert.Equal("J", c.Type);
        }

        //Set Suit for card
        [Fact]
        public void SetSuitForCard()
        {
            Card c = new Card(Suit.Diamonds, "K");
            c.Suit = Suit.Hearts;
            Assert.Equal(Suit.Hearts, c.Suit);
        }

        //Test Remove card that exists
        [Fact]
        public void RemoveCardThatExists()
        {
            Deck<Card> testDeck = new Deck<Card>();
            Card c1 = new Card(Suit.Hearts, "Q");
            Card c2 = new Card(Suit.Diamonds, "2");
            testDeck.Add(c1);
            testDeck.Add(c2);
            testDeck.Remove(c2);
            Assert.Equal(1, testDeck.count);
        }

        //Test Remove card that does not exist
        [Fact]
        public void RemoveCardThatDoesNotExist()
        {
            Deck<Card> testDeck = new Deck<Card>();
            Card c1 = new Card(Suit.Hearts, "Q");
            Card c2 = new Card(Suit.Diamonds, "2");
            Card c3 = new Card(Suit.Spades, "J");
            testDeck.Add(c1);
            testDeck.Add(c2);
            testDeck.Remove(c3);
            Assert.Equal(2, testDeck.count);
        }

    }
}
