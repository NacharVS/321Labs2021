using System;
using System.Collections.Generic;
using System.Text;
using _0302.Unit;
using _0302.InterfaceWeapon;
using _0302.InterfaceUnit;

namespace _0302.House
{
    class PostHouse : Parametrs
    {
        List<Archer> archlist { get; set; }
        //public int sumarcher { get; set; }
        //public int DamageGarnisone { get; set; }

        public int healf => throw new NotImplementedException();

        public int berserk => throw new NotImplementedException();

        public int defense => throw new NotImplementedException();

        public int speed => throw new NotImplementedException();

        public int Damage { get; set; }

        public int Durability => throw new NotImplementedException();

        public PostHouse()
        {
            archlist = new List<Archer>();
        }

        public void Atack()
        {
            foreach (var arch in archlist)
            {
                Damage += arch.Damage;
                //Console.WriteLine(arch.DamageGarnisone);
            }
            Console.WriteLine($" Урон башни:{ Damage}");
        }

        public void Par()
        {
            throw new NotImplementedException();
        }

        public void Add(Archer ar)
        {
            archlist.Add(ar);
            
        }

        public void Hit()
        {
            throw new NotImplementedException();
        }

        public void Repair()
        {
            throw new NotImplementedException();
        }
    }
}
