namespace Group321.Examples
{
    class Warrior : Unit
    {
        public int Damage { get; set; }

        public override int Health
        {
            get => 200;
        }

        public void Attack()
        {
            System.Console.WriteLine("is attacking...");
        }

        public override void Action()
        {
            Attack();
        }
    }
}
