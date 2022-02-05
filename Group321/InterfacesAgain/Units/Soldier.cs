using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Soldier : IntUnit
    {
        public Soldier(double hp, double damage, double armor, double movespeed)
        {
            Hp = hp;
            Damage = damage;
            Armor = armor;
            MoveSpeed = movespeed;
        }

        public Soldier()
        {

        }

        public double Hp { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double MoveSpeed { get; set; }
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
