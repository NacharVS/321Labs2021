using Group321.InterfacesAgain.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Garrison : IntGarrison
    {
        public double Damage { get; set; }
        public string Name { get; set; }
        public double Armor { get; set; }

        public Garrison()
        {
            unitsList = new List<Archer>();
        }

        public void Attack()
        {
            foreach (var item in unitsList)
            {
                Damage += item.Damage;
                Console.WriteLine(item.Damage);
            }

            Console.WriteLine($"Гарнизон атаковал с уроном {Damage}");
        }

        public void Add(Archer unit)
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
