using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Soldier
    {
        public int Health = 30;
        public void Blow(IMleeWeapon weapon)
        {
            weapon.Hit();
        }

    }
}
