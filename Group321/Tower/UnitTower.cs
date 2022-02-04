using System;
using System.Collections.Generic;
using System.Text;
using Group321.InterfacesAgain;
using Group321.InterfacesAgain.Weapons;

namespace Group321.Tower
{
    class UnitTower
    {
        public Bow MakeBow()
        {
            return new Bow();
        }

        public Sword MakeSword()
        {
            return new Sword();
        }

        public void Repair(IRepairible item)
        {
            item.Repair();
        }
    }
}
