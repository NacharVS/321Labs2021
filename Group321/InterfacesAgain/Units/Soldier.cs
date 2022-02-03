using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Soldier
    {
        public void Blow(IMleeWeapon weapon)
        {
            weapon.Hit();
        }

    }
}
