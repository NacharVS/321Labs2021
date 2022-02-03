using Group321.Interfaces. .InterfacesAgain.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.Interfaces
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
