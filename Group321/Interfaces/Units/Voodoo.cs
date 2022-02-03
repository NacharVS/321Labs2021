using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group321.Interface;

namespace Group321.Interfaces.Units
{
    class Voodoo : IUnit
    {
        public Voodoo(double hp, double damage, double armor, double run)
        {
            Hp = hp;
            Damage = damage;
            Armor = armor;
            Run = run;
        }

        public Voodoo()
        {

        }

        public double Hp { get; set; }
        public string Name { get; set; } = "Voodoo";
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Run { get; set; }

        public void Berserk(IUnit unit)
        {
            unit.Damage += unit.Damage * 0.05;
            unit.Armor += unit.Armor * 0.05;
            Console.WriteLine($"+50% damage -50% armor {unit.Name}");
        }

        public void KamennayaKoja(IUnit unit)
        {
            unit.Hp += unit.Hp * 0.02;
            unit.Run += unit.Run * 0.04;
            Console.WriteLine("+20% hp +30% armor +40% Run");
        }

        public void Spasenie(IUnit unit)
        {
            unit.Hp += unit.Hp;
            Console.WriteLine($"+100% hp {unit.Name}");
        }
    }
}