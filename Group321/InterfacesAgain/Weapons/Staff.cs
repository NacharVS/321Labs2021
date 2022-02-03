using Group321.InterfacesAgain.WeaponsImpementatin;
using Group321.InterfacesAgain.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Weapons
{
    class Staff : IBaffWeapon , IRepairible
    {
        public int BafDef => 50;

        public int BafAtt => 50;
        public int Durability { get => 20; set => throw new NotImplementedException(); }
        public int baff { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int duration { get => 20; set => throw new NotImplementedException(); }
        int IBaffWeapon.BafDef { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IBaffWeapon.BafAtt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Baff()
        {
            Console.WriteLine($"{GetType().Name} WFFFFEEEEW! {baff} {GetType().Name} ");
        }

        public void Repair()
        {
            Console.WriteLine("Staff repaired");
        }

        public void Salvation()
        {
            Console.WriteLine($"Resurrects a character with full resources and lasts {duration} second");
        }

        void IBaffWeapon.BafedAtt()
        {
            Console.WriteLine($"Buff on Berserk: + Damage {BafAtt}%, - defense {BafDef}% and lasts {duration} second");
        }

        void IBaffWeapon.BafedDef()
        {
            Console.WriteLine($"Buff on stone skin: + defense {BafDef}% and lasts {duration} second");
        }
    }
}
