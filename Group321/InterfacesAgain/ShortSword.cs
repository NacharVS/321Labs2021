using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class ShortSword : IWeapon, IRepairible
    {
        public int Damage { get => 8; set => throw new NotImplementedException(); }
        public int Durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
