using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public double Hp { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Run { get; set; }

        public void Berserk()
        {
            Console.WriteLine("+50% damage -50% armor");
        }

        public void KamennayaKoja()
        {
            Console.WriteLine("+20% hp +30% armor +40% Run");
        }

        public void Spasenie()
        {
            Console.WriteLine("+100% hp");
        }
    }
}