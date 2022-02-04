using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практика_интерфейсы.WeaponsImpementatin;
using Практика_интерфейсы.Weapons;

namespace Практика_интерфейсы.Warriors
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
