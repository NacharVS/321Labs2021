using System;
using Group321.Interfaces.WeaponsImpementatin;
using System.Collections.Generic;
using System.Text;

namespace Group321.Interfaces
{
    class StoneAxe : IMleeWeapon, IRepairible
    {
        public int Damage { get => 6; set => throw new NotImplementedException(); }
        public int Durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
