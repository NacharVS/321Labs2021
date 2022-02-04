using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_интерфейсы.WeaponsImpementatin
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
