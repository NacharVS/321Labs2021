using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.InterfacesGarrison
{
    class Unit : IHeroes
    {
        public int Range => 20;

        public int Defense => 50;

        public void Action()
        {
            Console.WriteLine("321");
        }

        public void Move()
        {
            Console.WriteLine("121");
        }
    }
}
