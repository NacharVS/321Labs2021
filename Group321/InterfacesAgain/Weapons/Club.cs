using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практика_интерфейсы.WeaponsImpementatin;

namespace Практика_интерфейсы.Weapons
{
    class Club : IMleeWeapon, IRepairible
    {
        public int Damage { get => 3; set => throw new NotImplementedException(); }
        public int Durability { get => 5; set => throw new NotImplementedException(); }

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
