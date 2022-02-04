using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class PhantomAssasin : IUnits
    {
        public PhantomAssasin(string name, double damage, double armor, double hp, double run)
        {
            Name = name;
            Damage = damage;
            Armor = armor;
            Hp = hp;
            Run = run;
        }

        public PhantomAssasin()
        {

        }

        public string Name { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Hp { get; set; }
        public double Run { get; set; }



        public void Baff()
        {
            DD();
        }

        public void DD()
        {
            Console.WriteLine("Вы получили удвоенный урон, Вас бафает Drow Ranger, вы получиил + 100% урона, -  50% Защиты");
        }

        public void DD(IUnits units)
        {
            units.Damage = ((units.Damage / 100) * 100) + units.Damage;
            units.Armor = (units.Armor * 0.5);
            Console.WriteLine("Вы получили удвоенный урон, Вас бафает Drow Ranger, вы получиил + 100% урона, -  50% Защиты");
        }

        public void Lich()
        {
            Console.WriteLine("Вас бафнул Лич, Frost Shield даёт вам + 50% к броне, - 30% hp");
        }
        public void Lich(IUnits units)
        {
            units.Armor = ((units.Armor / 100) * 50) + units.Armor;
            units.Hp = (units.Hp * 0.3);
            Console.WriteLine("Вас бафнул Лич, Frost Shield даёт вам + 50% к броне, - 30% hp");
        }
    }
}
