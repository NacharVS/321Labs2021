using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практика_интерфейсы.WeaponsImpementatin;

namespace Практика_интерфейсы.Weapons
{
    class ShortSword : IMleeWeapon, IRepairible
    {
        public int Damage { get => 8; set => throw new NotImplementedException(); }
        public int Durability { get => 20; set => throw new NotImplementedException(); }

        public string CopyRight = "Lesha. Popov";
        public void Hit()
        {
            Console.WriteLine("shooh-shooh");
        }

        public void Repair()
        {
            Console.WriteLine("Sword repaired");
        }
    }
}
