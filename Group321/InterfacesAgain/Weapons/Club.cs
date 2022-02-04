using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Club : IMleeWeapon, IRepairible
    {
        public int Damage { get => 3; set => throw new NotImplementedException(); }
        public int Durability { get => 10; set => throw new NotImplementedException(); }

        public int ThrowDamage => throw new NotImplementedException();

        public string CopyRight = "Oak. Nearest forest";
        public void Hit()
        {
            Console.WriteLine($"tun-tun");
        }

        public void Repair()
        {
            Console.WriteLine("Club repaired");
        }

        public void Throw()
        {
            throw new NotImplementedException();
        }
    }
}
