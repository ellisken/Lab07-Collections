using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardDeckCollections.Classes
{
    public class Deck<T> : IEnumerable
    {
        T[] cards = new T[10];
        public int count = 0;

        /// <summary>
        /// Enumerator to allow foreach for cards
        /// </summary>
        /// <returns>each item from the deck</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
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
            if(count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }
            cards[count++] = card;
        }

        /// <summary>
        /// Removes an item from the deck
        /// </summary>
        /// <param name="card">item to be removed</param>
        public void Remove(T card)
        {
            for(int i = 0; i < count; i++)
            {
                if (card.Equals(cards[i]))
                {
                    for(int j = i; j < count - i - 1; j++)
                    {
                        cards[j] = cards[j + 1];
                    }
                    count--;
                }
            }
        } 
        
        /// <summary>
        /// Returns an array of cards in the deck that have the specified suit
        /// </summary>
        /// <param name="suit">Suit of cards to return</param>
        public T[] ReturnSuit(Suit suit)
        {
            List<T> cardsInDeckWithSuit = new List<T>();
            for(int i=0; i < count; i++)
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
