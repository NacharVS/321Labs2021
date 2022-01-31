using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Bow : IWeapon, IRepairible
    {
        public int SumArrow = 2;
        public int Damage { get => 10; set => throw new NotImplementedException(); }
        public int Durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string CopyRight = "Talgat Yarull";
        public void Hit()
        {
            if(SumArrow>0)
            {
                Console.WriteLine("piy-piy");
                SumArrow--;
            }
            else
            Console.WriteLine("shuh-shuh");
            
        }

        public void Repair()
        {
            Console.WriteLine("Bow repaired");
        }
    }
}
