using System;
using System.Collections.Generic;
using System.Text;

namespace _0302.InterfaceWeapon
{
    interface IrageWeapon : IRepairible
    {
        int range { get; }
    }
}
