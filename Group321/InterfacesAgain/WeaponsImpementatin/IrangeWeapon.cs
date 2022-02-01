using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.WeaponsImpementatin
{
    interface IrangeWeapon : IRepairible, IWeapon
    {
        int range { get; }
    }
}
