using System;
using System.Collections.Generic;
using System.Text;

namespace _0302.InterfaceWeapon
{
    interface IThrowableWeapon : IRepairible
    {
        int Damage { get; }

        void Hit();
    }
}
