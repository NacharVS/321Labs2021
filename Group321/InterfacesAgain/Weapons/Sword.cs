using System;
using System.Collections.Generic;
using System.Text;
using Group321.InterfacesAgain.WeaponsImpementatin;

namespace Group321.InterfacesAgain.Weapons
{
    class Sword : IThrowableWeapon
    {
        public int Damage => 15;

        public int Durability => 50;

        public void Hit()
        {
            Console.WriteLine($"shooh-shooh {Damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has repaired");
        }
    }
}
