using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense.Examples
{
    class Archer : IArcherAction, ISleep, IAction
    {
        public int Range => 50;
        public int Damage => 14;

        public int Defence => 20;
        public int NewHealth { get; set; }

        public int NewDamage { get; set; }

        public int NewDefence { get; set; }

        public int Health => 100;

        public int BuffDamage { get; set; }

        public int BuffHealth { get; set; }

        public int BuffDefence { get; set; }

        public void Action()
        {
            System.Console.WriteLine("Making training");
        }

        public void Characteristic()
        {
            System.Console.WriteLine($"Health: {NewHealth}, Damage: {NewDamage} ");
        }

        public void ArcherBuffed()
        {
            System.Console.WriteLine("Archer Buffed");
        }

        public void Fire()
        {
            System.Console.WriteLine($"Fired: {NewDamage} ");
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
