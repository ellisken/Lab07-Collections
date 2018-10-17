using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardDeckCollections.Classes
{
    class Deck<T> : IEnumerable
    {
        List<T> cards = new List<T>();

        /// <summary>
        /// Enumerator to allow foreach for cards
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                yield return cards[i];
            }
        }

        // Required to allow enumeration with legacy code
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Adds a new card to the deck. If the deck is full, resizes
        /// the deck to twice the previous length and then adds the new care
        /// </summary>
        /// <param name="card">New card to be added</param>
        public void Add(T card)
        {
            cards.Add(card);
        }

        public void Remove(T card)
        {
            cards.Remove(card);
        }
        
        /// <summary>
        /// Returns an array of cards in the deck that have the specified suit
        /// </summary>
        /// <param name="suit">Suit of cards to return</param>
        public T[] ReturnSuit(Suit suit)
        {
            List<T> cardsInDeckWithSuit = new List<T>();
            for(int i=0; i < cards.Count; i++)
            {
                Card currentCard = (Card)Convert.ChangeType(cards[i], typeof(Card));
                //If the card has the given suit, add to list
                if (currentCard.Suit == suit)
                {
                    cardsInDeckWithSuit.Add(cards[i]);
                }
            }

            return cardsInDeckWithSuit.ToArray();
        }
    }
}
