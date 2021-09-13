using System;

namespace Group321.Examples
{
    class Unit
    {      
        private int _health = 100;
        private int _speed = 20;

        public virtual int Health
        {
            get => _health;
            set
            {
                _health = value;
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

        public void Move()
        {
            Console.WriteLine("is moving");
        }

        public virtual void Action()
        {
            Console.WriteLine("making activity");
        }

    }
}

