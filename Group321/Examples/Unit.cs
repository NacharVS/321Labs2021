using System;

namespace Group321.Examples
{
    class Unit
    {
        public delegate void ValueChangedDelegate(string message);

        private int _health = 100;
        private int _speed = 20;

        public virtual int Health
        {
            get => _health;
            set
            {
                var diff = _health - value;
                if (_health > 0)
                {
                    if (_health < diff)
                    {
                        _health = 0;
                        ValueChangedEvent?.Invoke($"Health chahded by {diff} current Health - {_health}");
                        DeathEvent?.Invoke();
                    }
                    else
                    {
                        _health = value;
                        ValueChangedEvent?.Invoke($"Health chahded by {diff} current Health - {_health}");
                    }
                }
                else
                {
                    _health = 0;
                    DeathEvent?.Invoke();
                }
            }
        }

        public int Speed
        {
            get => _speed;
            set
            {
                _speed = value;
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

