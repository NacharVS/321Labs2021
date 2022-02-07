using Group321.InterfacesGarrison.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesGarrison.Class
{
    class Peasant : IPeasant
    {
        public int Defense => 5;

        public void Action()
        {
            Console.WriteLine("Ya choto-to govory");
        }

        public void Move()
        {
            Console.WriteLine("top-top");
        }
    }
}
