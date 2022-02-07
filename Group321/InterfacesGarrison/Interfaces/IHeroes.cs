using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.InterfacesGarrison
{
    interface IHeroes
    {
        int Defense { get; }

        void Action();

        void Move();
    }
}
