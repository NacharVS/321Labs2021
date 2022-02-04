using System;
using System.Collections.Generic;
using System.Text;
using _0302.Unit;
using _0302.InterfaceUnit;

namespace _0302.House
{
    class UnitHouse
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
