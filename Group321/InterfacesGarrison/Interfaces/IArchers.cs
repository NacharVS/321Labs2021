using Group321.InterfacesGarrison.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.InterfacesGarrison
{
    interface IArchers : IHeroes, IDistantBattle
    {
        int Damage { get; }
        void Hit();
    }
}
