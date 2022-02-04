using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.WeaponsImpementatin
{
    interface IBaff : IRepairible
    {
        int duration { get; set; }
        int BafDef { get; set; }
        int BafAtt { get; set; }

        void resurrection();
        void BafedDef();
        void BafedAtt();
        void Salvation();
    }
}
