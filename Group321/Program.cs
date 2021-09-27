using Group321.Examples;
using System;

namespace Group321
{
    class Program
    {
        delegate void MessageDelegate(string message);

        static void Main(string[] args)
        {
            Unit unit = new Unit();
            unit.ValueChangedEvent += ShowInfo;
            unit.DeathEvent += Death;
            unit.InflictDamage(10);
            unit.InflictDamage(10);
            unit.InflictDamage(40);
            unit.InflictDamage(50);
            unit.InflictDamage(50);
        }

        static void Death()
        {
            Console.WriteLine("Is dead");
        }

        static void ShowInfo(string info)
        {
            Console.WriteLine(info);
        }
    }
}
