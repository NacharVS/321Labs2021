using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    public class Peasants : Units
    {
        public override double Health
        {
            get => health;
            set => health = value;
        }
        public Peasants(double healthPeasant)
        {
            healthPeasant = health;
        }
        public void Action()
        {
            System.Console.WriteLine($"Mining gold. Has {health} HP");
        }

        public void Move()
        {
            System.Console.WriteLine("Going to work");
        }

        public void Sleep()
        {
            System.Console.WriteLine("Peasant sleep");
        }

        public void Work()
        {
            System.Console.WriteLine("is working...");
        }
    }
}
