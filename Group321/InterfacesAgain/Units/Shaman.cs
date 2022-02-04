using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Shaman : IBaff
    {
        public int Health = 20;

        public int BafDef => 50;

        public int BafAtt => 50;
        public int Durability { get => 20; set => throw new NotImplementedException(); }
        public int baff { get => 10; set => throw new NotImplementedException(); }
        public int duration { get => 20; set => throw new NotImplementedException(); }
        int IBaff.BafDef { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IBaff.BafAtt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Soldier Solomon = new Soldier();

        public void Baff()
        {
            Console.WriteLine($"{GetType().Name} WFFFFEEEEW! {baff} Health {Solomon.GetType().Name} ");
        }

        public void Repair()
        {
            Console.WriteLine("Staff repaired");
        }

        public void Salvation()
        {
            Console.WriteLine($"Resurrects a character with full resources and lasts {duration} second");
        }

        void IBaff.BafedAtt()
        {
            Console.WriteLine($"Buff on Berserk: + Damage {BafAtt}%, - defense {BafDef}% and lasts {duration} second");
        }

        void IBaff.BafedDef()
        {
            Console.WriteLine($"Buff on stone skin: + defense {BafDef}% and lasts {duration} second");
        }
        public void resurrection()
        {
            Console.WriteLine($"Resurrection {Solomon.GetType().Name}");
        }

        public void SoldierBuff()
        {
            Console.WriteLine($"Buff on Berserk:{Solomon.GetType().Name} + Damage {BafAtt}%, - defense {BafDef}% and lasts {duration} second");
        }

    }
}
