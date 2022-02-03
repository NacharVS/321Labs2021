using Group321.InterfacesAgain.Weapons;
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
        public Staff MakeStaff()
        {
            return new Staff();
        }

        public ShortSword MakeSword()
        {
            return new ShortSword();
        }

        public Bow MakeBow()
        {
            return new Bow();
        }

        public Knife MakeKnife()
        {
            return new Knife();
        }

        public void Repair(IRepairible item)
        {
            item.Repair();
        }
    }
}
