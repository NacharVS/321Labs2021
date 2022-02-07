using System;
using System.Collections.Generic;
using System.Text;
using _0302.InterfaceWeapon;
using _0302.House;
using _0302.Unit;

namespace Group321.Weapon
{
    class Sling : IThrowableWeapon
    {
        public int range => 15;

        public int Durability => 10;

        public int Damage => 20;

        public void Hit()
        {
            Console.WriteLine($"pyx-pyx {Damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has repaired");
        }
    }
}
