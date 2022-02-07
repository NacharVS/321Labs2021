using Group321.InterfacesAgain;
using Group321.InterfacesAgain.Units;
using Group321.InterfacesAgain.Weapons;
using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Group321
{
    class Program : Tower   
    {
        delegate void MessageDelegate(string message);

        static void Main(string[] args)
        {
            Soldier soldier = new Soldier("Pudge", 60, 100, 150, 25);
            Archer archer = new Archer("Windranger", 15, 20, 130, 10);
            PhantomAssasin phantomAssasin = new PhantomAssasin("Assasin", 40, 20, 200, 30);
            Svinger svinger = new Svinger("Bounty hunter", 100, 25, 250, 70);
            Shaman Victor = new Shaman();
            Toverna toverna = new Toverna();
            Blacksmith blacksmith = new Blacksmith();
            var Svinger = toverna.MakeSvinger();
            phantomAssasin.Lich(phantomAssasin);
            phantomAssasin.Lich(soldier);
            phantomAssasin.DD(phantomAssasin);
            Console.WriteLine($"Name:{phantomAssasin.Name} Damage:{phantomAssasin.Damage} armor:{phantomAssasin.Armor} hp{phantomAssasin.Hp} run:{phantomAssasin.Run}");
            var bow = blacksmith.MakeBow();
            var knife = blacksmith.MakeKnife();
            soldier.Blow(knife);
            soldier.Throw(knife);
            archer.Shoot(bow);
            svinger.Shoot(bow);
            phantomAssasin.DD(Svinger);
            Console.WriteLine($"Name:{svinger.Name} Damage:{svinger.Damage} Armor:{svinger.Armor} HP:{svinger.Hp} Run:{svinger.Run}");
            blacksmith.Repair(knife);
            blacksmith.Repair(bow);
        }

        public void AddArcher(Archer unit)
        {
            units.Add(unit);
        }

        public void AddSvinger(Svinger unit)
        {
            Units.Add(unit);
        }

        List<Archer> units { get; }
        List<Svinger> Units { get; }

        public Program()
        {
            units = new List<Archer>();
            Units = new List<Svinger>();
        }
    }
}
