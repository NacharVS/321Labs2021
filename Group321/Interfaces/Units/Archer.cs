using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group321.Interfaces.WeaponsImpementatin;
using Group321.Interfaces;

namespace Group321.Interfaces.Units
{
    class Archer : IUnit
    {
        public Archer(double hp, double damage, double armor, double run)
        {
            Hp = hp;
            Damage = damage;
            Armor = armor;
            Run = run;
        }

        public Archer()
        {

        }

        public double Hp { get; set; }
        public string Name { get; set; } = "Archer";
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Run { get; set; }

        public void Throw(IThrowableWeapon weapon)
        {
            weapon.Hit();
        }

        public void Shoot(Bow weapon)
        {
            weapon.Hit();
        }
    }
}
