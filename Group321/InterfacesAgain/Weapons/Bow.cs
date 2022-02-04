using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Bow : IrangeWeapon, IThrowableWeapon
    {
        public int range => 8;

        public int Durability => 30;

        public int Damage => 20;

        public int ThrowDamage => throw new NotImplementedException();

        public void Hit()
        {
            Console.WriteLine($"piu-piu {Damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has repaired");
        }

        public void Throw()
        {
            throw new NotImplementedException();
        }
    }
}
