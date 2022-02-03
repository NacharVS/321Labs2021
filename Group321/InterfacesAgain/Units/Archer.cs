using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Archer
    {
        public void Throw(IThrowableWeapon weapon)
        {
            weapon.Hit();
        }

    }
}
