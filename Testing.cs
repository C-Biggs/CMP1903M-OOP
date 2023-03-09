using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Testing
    {
        public static void Test()
        {
            Pack aPack = new Pack(); //Create an instance of the pack class


            aPack.shuffleCardPack(1); //Call the shuffle method to use the Fisher-Yates Shuffle

            Console.WriteLine(aPack.dealCard().ToString()); //Deal a single card
            Console.WriteLine(aPack.dealCard(4).ToString()); //Deal four cards
        }
    }
}
