using Group321.InterfacesGarrison.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesGarrison.Class
{
    class Slinger : ILaundryman
    {
        public int Damage => 20;

        public int Range => 15;

        public int Defense => 10;

        public void Action()
        {
            Console.WriteLine("Arrow pulling");
        }

        public void Hit()
        {
            Console.WriteLine($"taaa-daaam {Damage} damage");
        }

        public void Move()
        {
            Console.WriteLine("top-top");
        }
    }
}
