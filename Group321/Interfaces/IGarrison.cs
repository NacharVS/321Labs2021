using System;
using System.Collections.Generic;
using System.Text;
using Group321.Interfaces.Units;

namespace Group321.Interfaces
{
    interface IGarrison
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }

        public void Attack();
        public void Add(Archer archer);
        public void Delete(string name);
    }
}
