using Group321.Examples;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Tower
    {
        public Peasants CreatePeasants()
        {
            return new Peasants(50);
        }
    }
}
