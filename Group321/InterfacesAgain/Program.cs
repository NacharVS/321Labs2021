using Group321.InterfacesAgain;
using Group321.InterfacesAgain.Units;
using Group321.InterfacesAgain.Weapons;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Group321
{
    class Program : Barracks
    {
        delegate void MessageDelegate(string message);

        static void Main(string[] args)
        {
            Shaman Victor = new Shaman();
            Blacksmith Igor = new Blacksmith();
            Archer Amma = new Archer();
            Soldier Andrew = new Soldier();
            Victor.resurrection();
            Victor.SoldierBuff();
            var bow = Igor.MakeBow();
            Amma.Hit(bow);
        }

    }
}
