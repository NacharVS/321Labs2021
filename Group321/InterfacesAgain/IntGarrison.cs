using Group321.InterfacesAgain.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    interface IntGarrison
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }

        public void Attack();
        public void Add(Archer archer);
        public void Delete(string name);
    }
}
