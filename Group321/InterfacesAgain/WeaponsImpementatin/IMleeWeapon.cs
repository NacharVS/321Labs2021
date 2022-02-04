using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    public interface IMleeWeapon /*Рукопашное оружие*/
    {
        int Damage { get; }

        void Hit();
    }
}
