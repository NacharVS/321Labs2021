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
        List<Archer> unitlist { get; set; }


        public int healf => throw new NotImplementedException();

        public int berserk => throw new NotImplementedException();

        public int defense => throw new NotImplementedException();

        public int speed => throw new NotImplementedException();

        public int Damage { get; set; }

        public int Durability => throw new NotImplementedException();



        public PostHouse()
        {
            unitlist = new List<Archer>();
        }

        
        public void Atack()
        {
            foreach (var un in unitlist)
            {
                Damage += un.Damage;
                //Console.WriteLine(arch.DamageGarnisone);
            }
            Console.WriteLine($"Урон башни:{ Damage}");
        }

        public void Par()
        {
            throw new NotImplementedException();
        }

        public void Add(Archer ar)
        {
            unitlist.Add(ar); 
        }

        public void Hit()
        {
            //Console.WriteLine($"Урон башни:{ damage}");
        }

        public void Repair()
        {
            throw new NotImplementedException();
        }
    }
}
