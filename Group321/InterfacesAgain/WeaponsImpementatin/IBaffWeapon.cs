using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.WeaponsImpementatin
{
    interface IBaffWeapon : IRepairible
    {
        int baff { get; set; }

        void Baff();
    }
}
