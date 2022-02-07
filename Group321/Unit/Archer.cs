using System;
using System.Collections.Generic;
using System.Text;
using _0302.InterfaceWeapon;
using _0302.House;
using _0302.InterfaceUnit;

namespace _0302.Unit
{
    class Archer : Parametrs
    {
        
        public int healf => 50;
        public int berserk => 20;
        public int defense => 30;
        public int speed => 10;
        public int Damage => 30;

        public int Durability => throw new NotImplementedException();

        public void Blow(IThrowableWeapon weapon)
        {
            weapon.Hit();
        }

        public void Par()
        {           
            Console.WriteLine($"{GetType().Name} has established");
        }

        public void Add(Archer ar)
        {
            throw new NotImplementedException();
        }       
        
        public void Atack()
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
