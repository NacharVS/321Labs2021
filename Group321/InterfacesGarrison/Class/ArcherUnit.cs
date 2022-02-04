using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.InterfacesGarrison.Class
{
    class ArcherUnit : IArchers
    {
        public int Damage => 60;

        public int Defense => 60;

        public int Range => 20;

        public void Action()
        {
            Console.WriteLine("Arrow pulling");
        }

        public void Hit()
        {
            Console.WriteLine($"puf-puf {Damage} damage");
        }

        public void Move()
        {
            Console.WriteLine("top-top");
        }
    }
}
