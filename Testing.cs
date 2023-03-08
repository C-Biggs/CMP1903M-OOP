using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public Testing()
        {
            Pack aPack = new Pack();

            aPack.shuffleCardPack(1);

            Console.WriteLine(aPack.deal());
            Console.WriteLine(aPack.dealCard(4));
        }
    }
}
