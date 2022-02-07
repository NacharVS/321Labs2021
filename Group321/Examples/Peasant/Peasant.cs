using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense.Examples;

namespace TowerDefense.Examples
{
    class Peasant : IAction, ISleep, IPeasantAction
    {
        public int Health => 100;

        public int Damage => 3;

        public int Defence => 0;

        public int NewHealth { get; set; }

        public int NewDamage { get; set; }

        public int NewDefence { get; set; }

        public int BuffDamage { get; set; }

        public int BuffHealth { get; set; }

        public int BuffDefence { get; set; }

        public void Sleep()
        {
            System.Console.WriteLine("Sleep at night");
        }

        public void JoinTheArmy()
        {
            System.Console.WriteLine("The peasant joined the army");
        }

        public void Move()
        {
            System.Console.WriteLine("Harvest");
        }

        public void Characteristic()
        {
            System.Console.WriteLine($"Health: {Health}, Damage: {Damage} ");
        }

        public void Action()
        {
            System.Console.WriteLine("Work on thw field");
        }
    }
}
