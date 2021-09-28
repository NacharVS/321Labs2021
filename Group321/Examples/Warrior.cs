namespace Group321.Examples
{
    class Warrior : IAction, ISleep
    {
        public int Damage { get; set; }

        public int Health { get; set; }

        public void Action()
        {
            System.Console.WriteLine("Making training");
        }

        public void Attack()
        {
            System.Console.WriteLine("is attacking...");
        }

        public void Move()
        {
            System.Console.WriteLine("Going to Jerusalem");
        }

        public void Sleep()
        {
            System.Console.WriteLine("Warrion is not sleeping, warrior training");
        }
    }
}
