using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalnoeOruzieConsole.InterfacesAgain.WeaponsImpementatin;

namespace Group321.Interfaces
{
    interface IUnit
    {
        public double Hp { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Run { get; set; }
    }
}
