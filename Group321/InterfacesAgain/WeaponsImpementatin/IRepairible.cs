using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    interface IRepairible
    {
        int Durability { get; }
        void Repair();
    }
}
