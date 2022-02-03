using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Shaman
    {
        public int Health = 20;

        public void BaffDef(IBaffWeapon weapon)
        {
            weapon.BafedDef();
        }

        public void BafAtt(IBaffWeapon weapon)
        {
            weapon.BafedAtt();
        }

        public void Salvation (IBaffWeapon weapon)
        {
            weapon.Salvation();
        }

    }
}
