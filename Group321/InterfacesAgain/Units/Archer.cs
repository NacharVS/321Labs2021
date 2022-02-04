using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Archer
    {
        public int Health = 15;
        public void Hit(IThrowableWeapon weapon)
        {
            weapon.Hit();
        }

    }
}