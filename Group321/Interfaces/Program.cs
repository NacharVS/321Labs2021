using System;
using System.Collections.Generic;
using Group321.Interfaces.Units;
using System.Text;

namespace Group321.Interface
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            UnitFabrika unit = new UnitFabrika();
            var archer = unit.MakeArcher();
            var voodoo = unit.makeVoodoo();
            Blacksmith da = new Blacksmith();
            archer.Throw(da.MakeKnife());
            archer.Shoot(da.MakeBow());
            voodoo.Berserk(archer);
            voodoo.Berserk(voodoo);
        }
    }
}
