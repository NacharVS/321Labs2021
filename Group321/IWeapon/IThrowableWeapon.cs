using System;
using System.Collections.Generic;
using System.Text;

namespace GG.IWeapon
{
    interface IThrowableWeapon : IRepairible
    {
        int Damage { get; }
        void Hit();
    }
}
