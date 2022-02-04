using System;
using System.Collections.Generic;
using System.Text;
using Group321.InterfaceUnit;
using Group321.Unit;

namespace Group321.Tower
{
    class WeaponTower
    {
        public Archer MakeArcher()
        {
            return new Archer();
        }
        public Knight MakeKnight()
        {
            return new Knight();
        }
        public Shaman MakeShaman()
        {
            return new Shaman();
        }
    }
}
