using System;
using System.Collections.Generic;
using System.Text;

namespace GG.IWeapon
{
    interface IrangeWeapon : IRepairible
    {
        int range { get; }
    }
}
