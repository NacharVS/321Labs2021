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
        public int Health => 100;

        public int NewHealth { get; set; }

        public int NewDamage { get; set; }

        public int NewDefence { get; set; }


        public int Defence => 100;

        public int Damage => 10;

        public void Action()
        {
            System.Console.WriteLine("Making training");
        }

        public void BerserkBuff()
        {
            System.Console.WriteLine($"Shaman throw berserk buff:+ {BuffDamage}%, - {BuffHealth}%");
        }
        public void Characteristic()
        {
            System.Console.WriteLine($"Health: {Health}, Damage: {Damage} ");
        }
        public void StoneSkin()
        {
            System.Console.WriteLine($"Shaman throw stone skin buff:+ {BuffHealth}");
        }

        public void Salvation()
        {
            System.Console.WriteLine($"Shaman throw salvation");
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
