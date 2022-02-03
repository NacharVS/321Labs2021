using DalnoeOruzieConsole.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.Interfaces.Units
{
    class Soldier : IUnit
    {
        public Soldier(double hp, double damage, double armor, double run)
        {
            Hp = hp;
            Damage = damage;
            Armor = armor;
            Run = run;
        }

        public double Hp { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Run { get; set; }
        public void Blow(IMleeWeapon weapon)
        {
            weapon.Hit();
        }

        public void Throw(IThrowableWeapon weapon)
        {
            weapon.Hit();
        }

    }
}