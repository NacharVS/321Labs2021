using System;
using System.Collections.Generic;
using Group321.Interfaces.Units;
using System.Text;

namespace Group321.Interfaces
{
    class Program
    {
        public static void Main()
        {
            UnitFabrika unit = new UnitFabrika();
            var archer = unit.MakeArcher();
            var archer2 = unit.MakeArcher();
            var voodoo = unit.MakeVoodoo();
            var ogre = unit.MakeOgre();


            Garrison garrison = new Garrison();
            garrison.Add(archer);
            garrison.Add(archer2);


            Tower tower = new Tower(garrison);
            tower.Attack();

            Blacksmith david = new Blacksmith();
            var knife = david.MakeKnife();
            var bow = david.MakeBow();
            var club = new Club();

            archer.Throw(knife);
            ogre.Hit(club);
            archer.Shoot(bow);
            voodoo.Berserk(archer);
            voodoo.Berserk(voodoo);
        }
    }
}
