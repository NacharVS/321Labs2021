using System;
using System.Collections.Generic;
using System.Text;
using Group321.InterfaceUnit;

namespace Group321.Unit
{
    class Shaman : Parametrs
    {
        public int healf => 100;
        public int berserk => 40;
        public int defense => 50;
        public int speed => 15;
        public void Param()
        {
            Console.WriteLine($"{GetType().Name} has established");
        }
    }
}
