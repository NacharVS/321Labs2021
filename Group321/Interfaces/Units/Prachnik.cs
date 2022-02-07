using System;
using System.Collections.Generic;
using System.Text;
using Group321.Interfaces.UnitsImterfaces;

namespace Group321.Interfaces.Units
{
    class Prachnik : IPrachnik
    {
        public Prachnik(double range, string name, double hp, double damage, double armor, double run)
        {
            Range = range;
            Name = name;
            Hp = hp;
            Damage = damage;
            Armor = armor;
            Run = run;
        }

        public Prachnik()
        {

        }

        public double Range { get; set; }
        public string Name { get; set; }
        public double Hp { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Run { get; set; }
    }
}
