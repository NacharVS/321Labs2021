using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense.Examples
{
    class Bard : IAction, IBardAction, ISleep
    {
        public string Music => "All Star";
        public double MusicDuration => 2.5;
        public int Health { get; set; } 

        public int Damage { get; set; }

        public void Action()
        {
            System.Console.WriteLine("Making training");
        }
        public void Characteristic()
        {
            System.Console.WriteLine($"Health: {Health}, Damage: {Damage} ");
        }

        public void Play()
        {
            System.Console.WriteLine($"Play Music:{Music}");
        }


        public void Move()
        {
            System.Console.WriteLine("Play music all time");
        }

        public void Sleep()
        {
            System.Console.WriteLine("Bard is not sleeping, Bard training");
        }
    }
}
