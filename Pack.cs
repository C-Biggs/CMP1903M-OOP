using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> pack;
        public Pack() //Initialise card pack 
        {
            pack = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit))) //Nested foreach loops allow card creation for every value and suit 
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    pack.Add(new Card(suit, value)); //Adds the card to the pack list
                }
            }
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            List<Card> shuffledPack = new List<Card>();
            switch (typeOfShuffle)
            {
                case 1: //Fisher-Yates Shuffle
                    Random rnd = new Random();
                    
                    for (int i = 0; i < 52; i++)
                    {
                        Card tempCard = pack[rnd.Next(0,pack.Count())]; //Select a card at random from the pack and store it in a temporary variable
                        pack.Remove(tempCard); //Remove the selected card from the original pack
                        shuffledPack.Insert(0, tempCard); //Add selected card to a new list shuffledPack
                        pack = shuffledPack; //Copy the sorted list back into the pack list
                    }
                    return true;


                case 2: //Riffle Shuffle
                    List<Card> packA = new List<Card>(); //Initialise two lists to represent the two halves of the pack
                    List<Card> packB = new List<Card>();
                    for (int i = 0; i < 26; i++) //Itterate through the pack adding cards into the two halves
                    {
                        packA.Add(pack[i]);
                        packB.Add(pack[i + 26]);
                    }
                    for (int i = 0; i < 26; i++) //Itterate through the two halves alternating which half to add a card back to the sorted list
                    {
                        shuffledPack.Add(packA[i]);
                        shuffledPack.Add(packB[i]);
                    }
                    pack = shuffledPack; //Copy the sorted list back into the pack list
                    return true;


                case 3: //No Shuffle
                    return true;
                    

                default:
                    Console.WriteLine("Error: No Shuffle Type"); //Exception handling if an invalid case is used to select a sort
                    return false;
            }//Shuffles the pack based on the type of shuffle

        }
        public Card dealCard()
        {
            if (pack.Count== 0) //Ensures the pack has cards in before trying to deal a card
            {
                throw new InvalidOperationException("No cards in pack");
            }
            Card card = pack.FirstOrDefault(); //Takes top card from the pack list
            pack.Remove(card); //Removes the card from the pack list
            return card; //Returns the dealt card
            //Deals one card
        }


        public List<Card> dealCard(int amount)
        {
            if (pack.Count == 0) //Ensures the pack has cards in before trying to deal cards
            {
                throw new InvalidOperationException("No cards in pack");            
            }
            List<Card> cards = new List<Card>(); //Initialises a list to store the cards to be dealt
            for (int x = 1; x < amount; x++) //For loop to draw multiple cards
            {
                Card card = pack.FirstOrDefault(); //Takes top card from the pack list
                pack.Remove(card); //Removes the card from the pack list
                cards.Add(card); //Adds the card to the cards list
            }
            return cards; //Returns the cards list
            //Deals the number of cards specified by 'amount'
        }
    }
}
