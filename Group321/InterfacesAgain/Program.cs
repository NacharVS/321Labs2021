using Group321.InterfacesAgain;
using Group321.InterfacesAgain.Units;
using Group321.InterfacesAgain.Weapons;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Group321
{
    class Program
    {
        public static void Main()
        {
            Barracks unit = new Barracks();
            var archers = unit.MakeArcher();
            var archers2 = unit.MakeArcher();
            var shaman = unit.MakeShaman();
            var Soldier = unit.MakeSoldier();


            Garrison garrison = new Garrison();
            garrison.AddArcher(archers);
            garrison.AddArcher(archers2);
            garrison.AddSoldier(Soldier);
            garrison.AttackArcher();
            garrison.AttackSoldier();


            Blacksmith Igor = new Blacksmith();
            var knife = Igor.MakeKnife();
            var bow = Igor.MakeBow();
            var club = new Club();

            archers.Throw(knife);
            Soldier.Blow(club);
            archers.Shoot(bow);
            shaman.Resurrection(Soldier);
            shaman.Berserk(archers);
            shaman.StoneSkin(shaman);
        }
    }
}
