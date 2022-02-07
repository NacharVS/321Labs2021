using System;
using System.Collections.Generic;
using Group321.Interfaces.UnitsImterfaces;
using Group321.Interfaces.WeaponsImpementatin;
using System.Text;

namespace Group321.Interfaces
{
    class Garrison : IGarrison
    {
        List<IRangeUnit> unitsList { get; }
        public double Damage { get; set; }
        public string Name { get; set; }
        public double Armor { get; set; }

        public Garrison()
        {
            unitsList = new List<IRangeUnit>();
        }

        public void Attack(IrangeWeapon weapon)
        {
            foreach (var item in unitsList)
            {
                item.Shoot(weapon);
                Damage += item.Damage;
            }

            Console.WriteLine($"Гарнизон атаковал с уроном {Damage}");
        }

        public void Add(IRangeUnit unit)
        {
            unitsList.Add(unit);
        }

        public void Delete(string name)
        {
            foreach (var item in unitsList)
            {
                if (item.Name == name)
                    unitsList.Remove(item);
            }
        }
    }
}
