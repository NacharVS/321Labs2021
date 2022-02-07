using System;
using System.Collections.Generic;
using System.Text;
using GG.IWeapon;

namespace GG.Weapon
{
    class Bow : IrangeWeapon, IThrowableWeapon
    {
        public int range => 10;

        public int Durability => 30;

        public int Damage => 10;

        public void Hit()
        {
            Console.WriteLine($"cing-cing {Damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has repaired");
        }
    }
}
