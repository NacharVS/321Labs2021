using System;
using System.Collections.Generic;
using Group321.Interfaces.Units;
using System.Text;
using Group321.Interfaces;

namespace Group321.Interface
{
    class UnitFabrika
    {
        public Soldier MakeSoldier()
        {
            return new Soldier();
        }

        public Archer MakeArcher()
        {
            return new Archer();
        }

        public Voodoo makeVoodoo()
        {
            return new Voodoo();
        }
    }
}
