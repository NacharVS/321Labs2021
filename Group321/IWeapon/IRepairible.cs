using System;
using System.Collections.Generic;
using System.Text;

namespace GG.IWeapon
{
    interface IRepairible
    {
        int Durability { get; }
        void Repair();
    }
}
