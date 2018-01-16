using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckofCards
{
    /**
 * 
 * @author wanner
 * 
 * We have a Deck of Cards which will use the Card object we created.
 * A Deck of Cards contains all possible cards.
 * Here we will create all possible cards and add functionalities like,
 * shuffling and dealing one card.
 *
 */
    public class DeckofCards
    {

        private Card[] deck;                    //stores all cards.
        private int currentCard;                //index of the next card to be return by the caller.
        private const int NUMBER_OF_CARDS = 52; //number of cards in deck cannot be changed.

        /**
         * Constructor does not take any arguments but create the deck of all possible cards.
         */
        public DeckofCards()
        {
            String[] faceNames = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "king", "Ace" };
            String[] suits = { "Diamonds", "Clubs", "Hearts", "Spades" };

            currentCard = 0;
            deck = new Card[NUMBER_OF_CARDS];

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(faceNames[i % 13], suits[i / 13]);
            }
        }
        /**
         * Method to display the cards.
         */
        public void displayDeck()
        {
            foreach (Card card in deck)
            {
                Console.WriteLine(card);
            }
        }
        /**
         * Method will not return anything it will only shuffle the deck.
         * For each card during the for loop I get another random card and swap
         * positions.
         */
        public void shuffle()
        {
            currentCard = 0;
            Random randomNumber = new Random();
            for (int i = 0; i < deck.Length; i++)
            {
                int randomCard = randomNumber.Next(NUMBER_OF_CARDS);
                Card temp = deck[i];
                deck[i] = deck[randomCard];
                deck[randomCard] = temp;
            }
        }
        /**
         * This will deal a card off the deck and advance the currentCard
         * @return the top of the Card in the deck
         */
        public Card dealOneCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}

