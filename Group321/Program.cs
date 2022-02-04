using _0302.Unit;
using _0302.House;
using _0302.InterfaceWeapon;
using _0302.InterfaceUnit;
using System;

namespace _0302
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitHouse uh1 = new UnitHouse();
            var Lena = uh1.MakeArcher();
            Lena.Par();

            UnitHouse uh2 = new UnitHouse();
            var Boris = uh2.MakeShaman();
            Boris.Par();
            Boris.Fury(Lena);

            PostHouse ph3 = new PostHouse();

            //WeaponHouse wh = new WeaponHouse();
            //var bow1 = wh.MakeBow();

            //Lena.Blow(bow1);
        }
    }
}
