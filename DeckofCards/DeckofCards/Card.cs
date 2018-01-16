using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckofCards
{
    /**
    * @author Wanner
    * 
    * Class that creates the Card Object.
    * Each card has a face name and a suit.
    *
    */
    public class Card
    {

        private String faceName, suit;

        /**
         * The constructor initializes the instance variables.
         * @param faceName
         * @param suit
         * @param value
         */
        public Card(String faceName, String suit)
        {
            this.faceName = faceName;
            this.suit = suit;
        }
        /**
         *@return a String representation of the Card
         */
        public override String ToString()
        {
            return faceName + " of " + suit;
        }
    }
}
