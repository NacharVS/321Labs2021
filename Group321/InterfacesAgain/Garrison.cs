using Group321.InterfacesAgain.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Garrison : IntGarrison
    {
        List<Archer> unitsList { get; }
        List<Soldier> UnitsList { get; }
        List<Shaman> unitslist { get; }
        public double Damage { get; set; }
        public string Name { get; set; }
        public double Armor { get; set; }

        public Garrison()
        {
            unitsList = new List<Archer>();
            UnitsList = new List<Soldier>();
            unitslist = new List<Shaman>();
        }

        public void AttackArcher()
        {
            foreach (var item in unitsList)
            {
                Damage += item.Damage;
                Console.WriteLine(item.Damage);
            }

            Console.WriteLine($"Гарнизон лучников атаковал с уроном {Damage}");
        }
        public void AttackSoldier()
        {
            foreach (var item in unitsList)
            {
                Damage += item.Damage;
                Console.WriteLine(item.Damage);
            }

            Console.WriteLine($"Гарнизон солдатов атаковал с уроном {Damage}");
        }
        public void AttackShaman()
        {
            foreach (var item in unitsList)
            {
                Damage += item.Damage;
                Console.WriteLine(item.Damage);
            }

            Console.WriteLine($"Гарнизон шаманов атаковал с уроном {Damage}");
        }

        public void AddArcher(Archer unit)
        {
            unitsList.Add(unit);
        }
        public void AddSoldier(Soldier unit)
        {
            UnitsList.Add(unit);
        }
        public void AddShaman(Shaman unit)
        {
            unitslist.Add(unit);
        }

        public void DeleteArcher(string name)
        {
            foreach (var item in unitsList)
            {
                if (item.Name == name)
                    unitsList.Remove(item);
            }
        }
        public void DeleteSoldier(string name)
        {
            foreach (var item in UnitsList)
            {
                if (item.Name == name)
                    UnitsList.Remove(item);
            }
        }
        public void DeleteShaman(string name)
        {
            foreach (var item in unitslist)
            {
                if (item.Name == name)
                    unitslist.Remove(item);
            }
        }
    }
}
