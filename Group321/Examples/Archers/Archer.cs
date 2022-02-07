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
            System.Console.WriteLine("The archer making training");
        }

        public void Characteristic()
        {
            System.Console.WriteLine($"Health: {NewHealth}, Damage: {NewDamage}, Defence: {NewDefence} ");
        }

        public void ArcherBuffed()
        {
            System.Console.WriteLine("The archer Buffed");
        }

        public void Fire()
        {
            System.Console.WriteLine($"Fired: {NewDamage} ");
        }


        public void Move()
        {
            System.Console.WriteLine("The archer going to Tower");
        }

        public void Sleep()
        {
            System.Console.WriteLine("Archer is not sleeping, archer training");
        }
    }
}
