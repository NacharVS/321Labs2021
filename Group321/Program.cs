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
            var Lena = uh1.MakeArcher();//здание1 создает лучника
            Lena.Par();

            var Koly = uh1.MakeArcher();
            Koly.Par();

            var Boris = uh1.MakeShaman();
            Boris.Par();


            
            //Boris.Fury(Lena);//шаман улучшил способности юнита(ярость) 
            Boris.Salvation(Lena);
            

            WeaponHouse wh2 = new WeaponHouse();
            var bow1 = wh2.MakeBow();// здание2 создает оружие

            Lena.Blow(bow1);//лучник атакует оружием
            
            PostHouse ph3 = new PostHouse();
            ph3.Add(Lena);
            ph3.Add(Koly);
            //Console.WriteLine(Koly.DamageGarnisone);
            ph3.Atack();


        }
    }
}
