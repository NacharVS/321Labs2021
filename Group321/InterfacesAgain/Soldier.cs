using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Soldier : Units
    {
        public void Blow(IMleeWeapon weapon)
        {
            weapon.Hit();
        }

        public void Throw(IThrowableWeapon weapon)
        {
            weapon.Hit();
        }

    }
}
