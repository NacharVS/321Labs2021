using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практика_интерфейсы.WeaponsImpementatin;

namespace Практика_интерфейсы.Weapons
{
    class StoneAxe : IMleeWeapon, IRepairible
    {
        public int Damage { get => 6; set => throw new NotImplementedException(); }
        public int Durability { get => 15; set => throw new NotImplementedException(); }

        int IMleeWeapon.Damage => throw new NotImplementedException();

        public string CopyRight = "IvanMoskvin. Tula";



        public void Repair()
        {
            Console.WriteLine("Axe repaired");
        }

        void IMleeWeapon.Hit()
        {
            throw new NotImplementedException();
        }
    }
}

