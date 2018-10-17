using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardDeckCollections.Classes
{
    class Deck<T> : IEnumerable
    {
        T[] cards = new T[5];
        int count = 0;

        /// <summary>
        /// Enumerator to allow foreach for cards
        /// </summary>
        /// <returns></returns>
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

        public void Remove(T card)
        {
            for(int i=0; i < cards.Length; i++)
            {
            }
        }
        
        public void ReturnSuit(string suit)
        {

        }
    }
}
