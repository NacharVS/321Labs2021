﻿using System;
using System.Collections.Generic;
using System.Text;
using TowerDefense.Examples;

namespace TowerDefense.Examples
{
    class Post : IArcherAction, IPeasantAction
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

        public int Range => 50;

        public void Fire()
        {
            System.Console.WriteLine("Archer sit in a post");
        }

        public void Create()
        {
            System.Console.WriteLine($"The peasant became an archer - Health:{NewHealth}, Damage:{NewDamage}, Defence:{NewDefence}, Range:{Range}");
        }

        public void Sleep()
        {
            System.Console.WriteLine("The peasant sleep at post");
        }

        public void JoinTheArmy()
        {
            System.Console.WriteLine("The peasant joined the army");
        }

        public void Move()
        {
            System.Console.WriteLine("Go to Hell!");
        }

        public void Characteristic()
        {
            System.Console.WriteLine($"Health: {Health}, Damage: {Damage} ");
        }

        public void Action()
        {
            System.Console.WriteLine("Collect the Equipment");
        }
    }
}
