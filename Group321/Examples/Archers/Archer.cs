using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense.Examples
{
    class Archer : IArcherAction, ISleep, IAction
    {
        public int Range => 50;
        public int Damage { get; set; }

        public int Health { get; set; }

        public void Action()
        {
            System.Console.WriteLine("Making training");
        }

        public void Characteristic()
        {
            System.Console.WriteLine($"Health: {Health}, Damage: {Damage} ");
        }

        public void Fire()
        {
            System.Console.WriteLine($"Fired: {Damage} ");
        }


        public void Move()
        {
            System.Console.WriteLine("Going to Tower");
        }

        public void Sleep()
        {
            System.Console.WriteLine("Archer is not sleeping, archer training");
        }
    }
}
