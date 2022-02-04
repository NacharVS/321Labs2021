using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.WeaponsImpementatin
{
    interface IThrowableWeapon : IRepairible
    {
        int Damage { get;}

        void Hit();
    }
}
