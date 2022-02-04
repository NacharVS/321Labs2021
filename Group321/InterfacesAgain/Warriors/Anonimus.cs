using System;
using System.Collections.Generic;
using System.Text;
using Практика_интерфейсы.WeaponsImpementatin;
using Практика_интерфейсы.Weapons;

namespace Group321.InterfacesAgain.Warriors
{
    class Anonimus : IUnits
    {
        public Anonimus()
        {

        }

        public Anonimus(string name, double damage, double armor, double hp, double run)
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
        public void Shoot(Knife weapon)
        {
            Console.WriteLine("Вас заскамил анонимус!!");
            weapon.Hit();
        }

        public void Throw(IThrowableWeapon weapon)
        {
            Console.WriteLine("Ножик анонимуса летит вам прямо в голову вввжиик");
            weapon.Hit();
        }
    }
}
