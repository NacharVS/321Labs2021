using System;
using System.Collections.Generic;
using Group321.Interfaces.Units;
using System.Text;

namespace Group321.Interfaces
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
