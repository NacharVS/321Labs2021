using System;
using System.Collections.Generic;
using System.Text;

namespace _0302.InterfaceWeapon
{
    interface IMeleeWeapon : IRepairible
    {
        int Damage { get; }

        void Hit();
    }
}
