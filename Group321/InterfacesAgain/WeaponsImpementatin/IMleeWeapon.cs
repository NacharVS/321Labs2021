using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    interface IMleeWeapon
    {
        int Damage { get; }

        void Hit();
    }
}
