using Piano.InterfacesGarrison.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.InterfacesGarrison.Class
{
    class Pyromancer : IPyromancer
    {
        public int Damage => 120;

        public int DamagePyro => 15;

        public int Range => 20;

        public int Defense => 50;

        public void Action()
        {
            Console.WriteLine("Accumulates energy");
        }

        public void Hit()
        {
            Console.WriteLine($"vvvssshhhh  {Damage} and then it burns {DamagePyro}");
        }

        public void Move()
        {
            Console.WriteLine("top-top");
        }
    }
}
