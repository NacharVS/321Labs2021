using Group321.Interfaces.WeaponsImpementatin;
using Group321.Interfaces;
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

        public Soldier()
        {

        }

        public double Hp { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Run { get; set; }
        public string Name { get; set; } = "Soldier";

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