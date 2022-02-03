using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Barracks
    {
        public class Soldier
        {
            public void Blow(IMleeWeapon weapon)
            {
                weapon.Hit();
            }

        }
        public class Archer
        {
            public void Throw(IThrowableWeapon weapon)
            {
                weapon.Hit();
            }

        }
        public class Shaman
        {
            public void Baff(IBaffWeapon weapon)
            {
                weapon.Baff();
            }

        }

    }
}
