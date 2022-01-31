using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Blacksmith
    {      
        public StoneAxe MakeAxe()
        {
            return new StoneAxe();
        }

        public ShortSword MakeSword()
        {
            return new ShortSword();
        }

        public Bow MakeBow()
        {
            return new Bow();
        }

        public void Repair(IRepairible item)
        {
            item.Repair();
        }
    }
}
