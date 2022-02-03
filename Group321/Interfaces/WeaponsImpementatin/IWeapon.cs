using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.Interfaces.WeaponsImpementatin
{
    interface IMleeWeapon
    {
        int Damage { get; }

        void Hit();
    }
}
