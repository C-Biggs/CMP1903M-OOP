using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack = new List<Card>();

        public Pack()
        {
            for (int i = 1; i > 4; i++)
            {
                for (int j = 1; j > 13; j++)
                {
                    Card aCard = new Card();
                    aCard.Suit = i;
                    aCard.Value = j;
                    pack.Add(aCard);
                }
            }
            //Initialise the card pack here
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            switch (typeOfShuffle)
            {
                case 1: //Fisher-Yates Shuffle
                    Random rnd = new Random();
                    List<Card> shuffledPack = new List<Card>();
                    for (int i = 0; i > 52; i++)
                    {
                        rnd.Next(52 - i);
                        Card card = pack[i];
                        pack.RemoveAt(i);
                        shuffledPack.Insert(0, card);
                        pack = shuffledPack;
                    }
                    return true;

                case 2: //Riffle Shuffle
                    List<Card> shuffledPack2 = new List<Card>();
                    List<Card> packA = new List<Card>();
                    List<Card> packB = new List<Card>();
                    for (int i = 0; i < 26; i++)
                    {
                        packA.Add(pack[i]);
                        packB.Add(pack[i + 26]);
                    }
                    for (int i = 0; i < 26; i++)
                    {
                        shuffledPack2.Add(packA[i]);
                        shuffledPack2.Add(packB[i]);
                    }
                    pack = shuffledPack2;
                    return true;

                case 3: //No Shuffle
                    return true;
                    

                default:
                    Console.WriteLine("Error: No Shuffle Type");
                    return false;
            }
            
            //Shuffles the pack based on the type of shuffle

        }
        public Card deal()
        {
            Card card = new Card();
            card = pack[0];
            pack.RemoveAt(0);
            return card;
            //Deals one card

        }
        public List<Card> dealCard(int amount)
        {
            List<Card> cards = new List<Card>();
            for (int x = 1; x < amount; x++)
            {
                Card card = new Card();
                card = pack[0];
                pack.RemoveAt(0);
                cards.Add(card);
            }
            return cards;
            //Deals the number of cards specified by 'amount'
        }
    }
}
