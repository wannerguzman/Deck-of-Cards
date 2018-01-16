using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckofCards
{
    /**
     * Main class with main method that runs the deck of cards.
     */
    class MainClass
    {
        /**
        * Main method that demonstrate the usage of the program.
        * I create a Deck of cards print the deck out.
        * I shuffle the Deck and re-print
        * I then demonstrate dealOneCard for 53 calls showing that the 53rd call is null
        * @param args
        */
        public static void Main(String[] args)
        {
            DeckofCards myDeckofCards = new DeckofCards();
            Console.WriteLine("-----------------------Deck before shuffling-----------------------------");
            myDeckofCards.displayDeck();

            myDeckofCards.shuffle();
            Console.WriteLine("-----------------------Deck After Shuffling------------------------------");
            myDeckofCards.displayDeck();

            Console.WriteLine("-----------------------53 calls to dealOndeCard()------------------------");
            for (int i = 0; i < 53; i++)
            {
                Card result = myDeckofCards.dealOneCard();
                if (result == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
