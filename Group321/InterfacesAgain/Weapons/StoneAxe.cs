using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
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
