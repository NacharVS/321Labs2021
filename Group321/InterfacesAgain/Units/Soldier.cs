using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Soldier : IUnits
    {
        public Soldier()
        {

        }
        public Soldier (string name, double damage, double armor, double hp, double run)
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

        public void Blow(IMleeWeapon weapon)
        {
            weapon.Hit();
        }
        public void Throw(IThrowableWeapon weapon)
        {
            weapon.Hit();
        }

        internal void Blow(IrangeWeapon weapon)
        {
            weapon.Hit();
        }
    }
}
