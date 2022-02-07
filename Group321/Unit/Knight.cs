using System;
using System.Collections.Generic;
using System.Text;
using _0302.InterfaceWeapon;
using _0302.House;
using _0302.InterfaceUnit;

namespace _0302.Unit
{
    class Knight : Parametrs
    {
        public int healf => 100;
        public int berserk => 40;
        public int defense => 50;
        public int speed => 15;

        public int damage => throw new NotImplementedException();

        public int Damage => throw new NotImplementedException();

        public int Durability => throw new NotImplementedException();

        public void Blow(IMeleeWeapon weapon)
        {
            weapon.Hit();
        }
        /*public void Add(Archer ar)
        {
            throw new NotImplementedException();
        }*/

        public void Atack()
        {
            throw new NotImplementedException();
        }        

        public void Par()
        {           
            Console.WriteLine($"{GetType().Name} has established");
        }

        public void Add(Archer ar)
        {
            throw new NotImplementedException();
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
