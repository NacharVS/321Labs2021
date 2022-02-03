using Group321.InterfacesAgain.Units;
using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Barracks
    {
        public Soldier MakeSoldier()
        {
            return new Soldier();
        }

        public Archer MakeArcher()
        {
            return new Archer();
        }

        public Shaman MakeShaman()
        {
            return new Shaman();
        }
    }
}
