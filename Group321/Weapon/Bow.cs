using System;
using System.Collections.Generic;
using System.Text;
using _0302.InterfaceWeapon;
using _0302.House;
using _0302.Unit;

namespace _0302
{
    class Bow : IrageWeapon, IThrowableWeapon
    {
        public int range => 10;

        public int Durability => 30;

        public int Damage => 10;

        public void Hit()
        {
            Console.WriteLine($"piu-piu {Damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has repaired");
        }
    }
}
