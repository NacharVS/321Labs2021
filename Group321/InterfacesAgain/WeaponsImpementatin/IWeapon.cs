using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    interface IWeapon
    {
        int Damage { get; }

        void Hit();
    }
}
