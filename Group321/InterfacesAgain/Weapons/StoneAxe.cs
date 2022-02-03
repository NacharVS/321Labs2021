using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class StoneAxe : IMleeWeapon, IRepairible
    {
        public int Damage { get => 6; set => throw new NotImplementedException(); }
        public int Durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string CopyRight = "IvanMoskvin. Tula";

        public void Hit()
        {
            Console.WriteLine($"tish-tish");
        }

        public void Repair()
        {
            Console.WriteLine("Axe repaired");
        }
    }
}
