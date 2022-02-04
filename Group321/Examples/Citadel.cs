using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.Examples
{
    class Citadel
    {
        public Peasant CreatePeasant() 
        {
            return new Peasant(30);
        }
    }
}
