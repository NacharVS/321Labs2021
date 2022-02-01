using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Soldier 
    {
        public IWeapon weapon;

        public Soldier(IWeapon weapon)
        {
            this.weapon = weapon;
        }
    }
}
