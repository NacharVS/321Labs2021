using Group321.InterfacesAgain;
using Group321.InterfacesAgain.Units;
using Group321.InterfacesAgain.Weapons;
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
            Shaman Victor = new Shaman();
            Blacksmith blacksmith = new Blacksmith();
            PhantomAssasin phantomAssasin = new PhantomAssasin("Assasin", 40, 20, 200, 30);


            phantomAssasin.Lich(phantomAssasin);
            phantomAssasin.Lich(soldier);
            phantomAssasin.DD(phantomAssasin);

            Console.WriteLine($"Name:{phantomAssasin.Name} Damage:{phantomAssasin.Damage} armor:{phantomAssasin.Armor} hp{phantomAssasin.Hp} run:{phantomAssasin.Run}");
            var bow = blacksmith.MakeBow();
            soldier.Blow(bow);
            soldier.Throw(bow);

            blacksmith.Repair(bow);
        }

      

    }
}
