using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Archer : IUnits
    {
        public Archer()
        {

        }

        public Archer(string name, double damage, double armor, double hp, double run)
        {
            Name = name;
            Damage = damage;
            Armor = armor;
            Hp = hp;
            Run = run;
        }

        public string Name { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Hp { get; set; }
        public double Run { get; set; }
        public void Shoot(Bow weapon)
        {
            weapon.Hit();
        }

        public void Throw(IThrowableWeapon weapon)
        {
            weapon.Hit();
        }
    }
}