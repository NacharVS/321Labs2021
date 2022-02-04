using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.InterfacesGarrison
{
    interface IArchers : IHeroes
    {
        int Damage { get; }
        void Hit();
    }
}
