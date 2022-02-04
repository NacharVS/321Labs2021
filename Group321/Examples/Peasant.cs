namespace Group321.Examples
{
    class Peasant : IAction, ISleep
    {

        public int CarryWeight { get; set; }

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public int _health;

        public Peasant(int health)
        {
            _health = health;
        }

        public void Action()
        {
            System.Console.WriteLine($"Mining gold. Has {_health} HP");
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
