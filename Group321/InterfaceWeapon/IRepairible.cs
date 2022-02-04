using System;
using System.Collections.Generic;
using System.Text;

namespace _0302.InterfaceWeapon
{
    interface IRepairible
    {
        int Durability { get; }
        void Repair();
    }
}
