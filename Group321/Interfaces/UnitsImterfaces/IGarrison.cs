using System;
using System.Collections.Generic;
using System.Text;
using Group321.Interfaces.WeaponsImpementatin;

namespace Group321.Interfaces.UnitsImterfaces
{
    interface IGarrison
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }

        public void Attack(IrangeWeapon weapon);
        public void Add(IRangeUnit unit);
        public void Delete(string name);
    }
}
