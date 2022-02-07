using System;
using System.Collections.Generic;
using System.Text;
using GG.IWeapon;
using GG.Weapon;

namespace GG.House
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
