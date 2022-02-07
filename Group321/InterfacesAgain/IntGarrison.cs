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
        public void AddArcher(Archer archer);
        public void AddSoldier(Soldier soldier);
        public void AddShaman(Shaman shaman);

        public void DeleteArcher(string name);
        public void DeleteSoldier(string name);
        public void DeleteShaman(string name);
    }
}
