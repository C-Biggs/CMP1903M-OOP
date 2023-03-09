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
            Pack aPack = new Pack();


            aPack.shuffleCardPack(1);

            Console.WriteLine(aPack.deal().ToString());
            Console.WriteLine(aPack.dealCard(4).ToString());
        }
    }
}
