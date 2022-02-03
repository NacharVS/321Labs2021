using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    public class Shaman : IUnits
    {
        public Shaman(string name, double damage, double armor, double hp, double run)
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

        public void ALLBAFS()
        {
            Console.WriteLine("У вас все баффы");
            BERSERK();
            STONEARMOR();
        }
        public void BERSERK()
        {
            Console.WriteLine("Вас баффнул шаман, БЕРСЕРК дает вам: + 50% урона, - 50% защита");
        }
        public void STONEARMOR()
        {
            Console.WriteLine("Вас баффнул шаман, КАМЕННАЯ КОЖА дает вам: + 30% защита, - 40% урона");
        }
        public void STONEARMOR(IUnits units)
        {
            units.Armor = ((units.Armor / 100) * 30) + units.Armor;
            units.Hp = (units.Hp * 0.4);
            Console.WriteLine("Вас баффнул шаман, КАМЕННАЯ БРОНЯ дает вам: + 30% защита, -40% скорость");
        }
    }
}
