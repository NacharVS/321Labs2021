using System;
using System.Collections.Generic;
using System.Text;
using GG.IWeapon;

namespace GG.Weapon
{
    class Sword : IThrowableWeapon
    {
        public int Damage => 15;

        public int Durability => 50;

        public void Hit()
        {
            Console.WriteLine($"vshooh-vshooh {Damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has repaired");
        }
    }
}
