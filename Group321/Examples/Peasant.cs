namespace Group321.Examples
{
        class Peasant : Unit
        {
            public int CarryWeight { get; set; }

            public override int Health
            {
                get => 30;
            }

            public void Work()
            {
                System.Console.WriteLine("is working...");
            }
        }
    
}
