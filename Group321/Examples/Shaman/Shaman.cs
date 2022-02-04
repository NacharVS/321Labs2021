using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense.Examples
{
    class Shaman : IAction, IShamanAction, ISleep
    {
        public int BuffDamage { get; set; }

        public int BuffHealth { get; set; }

        public int BuffDefence { get; set; }
        public int Duration => 30;
        public int Health { get; set; }

        public int Defence => 100;

        public int Damage { get; set; }

        public void Action()
        {
            System.Console.WriteLine("Making training");
        }

        public void BerserkBuff()
        {
            System.Console.WriteLine($"Throw berserk buff:+ {BuffDamage}%, - {BuffHealth}%");
        }
        public void Characteristic()
        {
            System.Console.WriteLine($"Health: {Health}, Damage: {Damage} ");
        }
        public void StoneSkin()
        {
            System.Console.WriteLine($"Throw stone skin buff:+ {BuffHealth}");
        }

        public void Salvation()
        {
            System.Console.WriteLine($"Throw salvation");
        }


        public void Move()
        {
            System.Console.WriteLine("Going to hero");
        }

        public void Sleep()
        {
            System.Console.WriteLine("Shaman is not sleeping, shaman training");
        }
    }
}
