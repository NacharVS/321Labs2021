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


        public void Blow(IThrowableWeapon weapon)
        {
            weapon.Hit();
        }

        public void Par()
        {           
            Console.WriteLine($"{GetType().Name} has established");
        }

        
    }
}
