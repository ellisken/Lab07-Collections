using System;
using System.Reflection;
using CardDeckCollections.Classes;

namespace CardDeckCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a new deck with 10 cards...");

            //Create 10 new cards in a new deck
            Deck<Card> myDeck = new Deck<Card>();

            Card c1 = new Card(Suit.Hearts, "Q");
            Card c2 = new Card(Suit.Hearts, "K");
            Card c3 = new Card(Suit.Spades, "J");
            Card c4 = new Card(Suit.Spades, "1");
            Card c5 = new Card(Suit.Clubs, "5");
            Card c6 = new Card(Suit.Clubs, "3");
            Card c7 = new Card(Suit.Hearts, "9");
            Card c8 = new Card(Suit.Diamonds, "A");
            Card c9 = new Card(Suit.Diamonds, "7");
            Card c10 = new Card(Suit.Spades, "8");

            Card[] cards = { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 };
            for(int i=0; i < 10; i++)
            {
                myDeck.Add(cards[i]);
            }
            PrintCards(myDeck);

            InitiateNextAction("remove the Queen of Hearts");

            Console.WriteLine("Removing the Queen of Hearts...");
            myDeck.Remove(c1);
            PrintCards(myDeck);

            InitiateNextAction("add the Queen of Diamonds");

            Console.WriteLine("Adding the Queen of Diamonds...");
            Card c11 = new Card(Suit.Diamonds, "Q");
            myDeck.Add(c11);
            PrintCards(myDeck);

            InitiateNextAction("see only the cards in the deck that are Spades");

            Console.WriteLine("Here are all the cards in the deck that belong to the Spades suit:");
            Card[] allSpadeCards = myDeck.ReturnSuit(Suit.Spades);
            foreach(Card card in allSpadeCards)
            {
                Console.WriteLine($"{card.Type} {card.Suit}");
            }
            Console.WriteLine();

        }

        /// <summary>
        /// Prints the cards in the given deck to the console
        /// </summary>
        /// <param name="deck">Deck to be printed</param>
        public static void PrintCards(Deck<Card> cardDeck)
        {
            Console.WriteLine("The cards in your deck are: ");
            foreach (Card card in cardDeck)
            {
                Console.WriteLine($"{card.Type} {card.Suit}");
            }

        }

        /// <summary>
        /// Prompts the user to hit enter to start the next action,
        /// waits for user to press enter, clears console       
        /// </summary>
        /// <param name="action">Describes the next action in Main()</param>
        public static void InitiateNextAction(string action)
        {
            Console.WriteLine($"\n\n-- Hit <ENTER> to {action} --");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
