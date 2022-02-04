using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.InterfacesGarrison.Interfaces
{
    interface IPyromancer : IHeroes
    {
        int Damage { get; }
        int DamagePyro { get; }
        void Hit();
    }
}
