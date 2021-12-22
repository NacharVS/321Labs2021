using System;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            double str = Convert.ToDouble(Console.ReadLine());
            double dox = Convert.ToDouble(Console.ReadLine());
            Warrior war = new Warrior(str, dox);
        }
    }
}
