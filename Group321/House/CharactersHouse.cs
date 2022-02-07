using System;
using System.Collections.Generic;
using System.Text;
using GG.Characters;

namespace GG.House
{
    class CharactersHouse
    {
        public Archer MakeArcher()
        {
            return new Archer();
        }
        public Swordsman MakeSwordman()
        {
            return new Swordsman();
        }
        public Shaman MakeShaman()
        {
            return new Shaman();
        }
    }
}
