using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group321.Interfaces.UnitsImterfaces
{
    public interface IUnit
    {
        public string Name { get; set; }
        public double Hp { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Run { get; set; }
    }
}