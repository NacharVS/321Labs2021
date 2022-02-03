using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.WeaponsImpementatin
{
    public interface IUnits
    {
        string Name { get; set; }
        double Damage { get; set; }
        double Armor { get; set; }
        double Hp { get; set; }
        double Run { get; set; }
    }
}
