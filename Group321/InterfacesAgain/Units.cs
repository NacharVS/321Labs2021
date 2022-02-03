using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    public abstract class Units
    {
        public delegate void ValueChangedDelegate(string message);
        public static double health = 100;
        public static double speed = 20;
        public static double protection = 50;

        public virtual double Health
        {
            get => health;
            set
            {
                var diff = health - value;
                if (health > 0)
                {
                    if (health < diff)
                    {
                        health = 0;
                        ValueChangedEvent?.Invoke($"Health chahded by {diff} current Health - {health}");
                        DeathEvent?.Invoke();
                    }
                    else
                    {
                        health = value;
                        ValueChangedEvent?.Invoke($"Health chahded by {diff} current Health - {health}");
                    }
                }
                else
                {
                    health = 0;
                    DeathEvent?.Invoke();
                }
            }
        }

        public double Speed
        {
            get => speed;
            set
            {
                speed = value;
            }
        }

        public double Protection
        {
            get => protection;
            set
            {
                protection = value;
            }
        }
        public void InflictDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"Inflicted {damage} damage");
        }

        public event ValueChangedDelegate ValueChangedEvent;
        public event Action DeathEvent;
    }
}
