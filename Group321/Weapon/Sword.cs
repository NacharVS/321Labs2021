using System;
using System.Collections.Generic;
using System.Text;
using _0302.InterfaceWeapon;
using _0302.House;
using _0302.Unit;

namespace _0302
{
    class Sword : IThrowableWeapon
    {
        public int Damage => 15;

        public int Durability => 50;

        public void Hit()
        {
            Console.WriteLine($"shooh-shooh {Damage}") ;
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has repaired");
        }
    }
}
