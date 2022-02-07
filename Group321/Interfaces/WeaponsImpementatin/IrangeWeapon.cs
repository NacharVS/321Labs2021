using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.Interfaces.WeaponsImpementatin
{
    interface IrangeWeapon : IRepairible
    {
        int range { get; }
    }
}