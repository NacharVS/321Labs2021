using System;
using System.Collections.Generic;
using System.Text;
using _0302.InterfaceWeapon;

namespace _0302.House
{
    class WeaponHouse
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
