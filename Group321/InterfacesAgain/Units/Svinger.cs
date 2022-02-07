using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Svinger : IUnits
    {
        public Svinger(string name, double damage, double armor, double hp, double run)
        {
            Name = name;
            Damage = damage;
            Armor = armor;
            Hp = hp;
            Run = run;
        }

        public Svinger()
        {

        }

        public string Name { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Hp { get; set; }
        public double Run { get; set; }

        public void Throw(IThrowableWeapon weapon)
        {
            Console.WriteLine("Стрела свингера летит прямо в вас!");
            weapon.Hit();
        }

        public void Shoot(Bow weapon)
        {
            Console.WriteLine("Стрела свингера летит прямо в вас!");
            weapon.Hit();
        }

    }
}
