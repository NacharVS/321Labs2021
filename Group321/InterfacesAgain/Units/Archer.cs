using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Archer : IntUnit
    {
        public Archer(double hp, double damage, double armor, double movespeed)
        {
            Hp = hp;
            Damage = damage;
            Armor = armor;
            MoveSpeed = movespeed;
        }

        public Archer()
        {

        }

        public double Hp { get; set; }
        public string Name { get; set; } = "Archer";
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double MoveSpeed { get; set; }

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
