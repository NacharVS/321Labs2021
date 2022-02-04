using System;
using System.Collections.Generic;
using System.Text;
using Group321.InterfaceUnit;
using Group321.InterfacesAgain.WeaponsImpementatin;

namespace Group321.Unit
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

        public void Param()
        {
            Console.WriteLine($"{GetType().Name} has established");
        }
    }
}
