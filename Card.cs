using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

    public enum Suit //Store names of each suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Value //Store names of each value
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    public class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public Value Value{ get; set; }
        public Suit Suit { get; set; }

        public Card (Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }


        public override string ToString() //Allows the cards to be output in a more readable way
        {
            return this.Value +  " of " + this.Suit; 
        }
    }
}
