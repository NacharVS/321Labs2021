using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Shaman : IntUnit
    {
        public Shaman(double hp, double damage, double armor, double movespeed)
        {
            Hp = hp;
            Damage = damage;
            Armor = armor;
            MoveSpeed = movespeed;
        }

        public Shaman()
        {

        }

        public double Hp { get; set; }
        public string Name { get; set; } = "Voodoo";
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double MoveSpeed { get; set; }

        public void Berserk(IntUnit unit)
        {
            unit.Damage += unit.Damage * 0.05;
            unit.Armor += unit.Armor * 0.05;
            Console.WriteLine($"Buff on Berserk: +50% damage -50% armor {unit.Name}");
        }

        public void KamennayaKoja(IntUnit unit)
        {
            unit.Hp += unit.Hp * 0.02;
            unit.MoveSpeed += unit.MoveSpeed * 0.04;
            Console.WriteLine($"Buff on stone skin: +20% hp +30% armor +40% Run {unit.Name}");
        }

        public void Spasenie(IntUnit unit)
        {
            unit.Hp += unit.Hp;
            Console.WriteLine($"Resurrection: +100% hp {unit.Name}");
        }
    }
}
