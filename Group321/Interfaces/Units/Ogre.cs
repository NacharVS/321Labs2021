using System;
using System.Collections.Generic;
using System.Text;
using Group321.Interfaces.WeaponsImpementatin;

namespace Group321.Interfaces.Units
{
    class Ogre : IUnit
    {
        public Ogre(double hp, double damage, double armor, double run, string name)
        {
            Hp = hp;
            Damage = damage;
            Armor = armor;
            Run = run;
            Name = name;
        }

        public Ogre()
        {

        }

        public double Hp { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Run { get; set; }
        public string Name { get; set; } = "Ogre";

        public void Hit(IMleeWeapon weapon)
        {
            weapon.Hit();
            Console.WriteLine("Вы превратились в лепешку RIP");
        }
    }
}
