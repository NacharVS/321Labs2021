using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Archer : Hero
    {
        public double MaxStr { get => 70;}
        public double MaxDox { get => 320;}
        public double MinStr { get => 30;}
        public double MinDox { get => 100;}
        public Archer(double strength, double doxterity) : base(strength, doxterity)
        {
            if (strength > MaxStr)
            {
                Console.WriteLine($"Максимальное значение силы {MaxStr}");
                this.strength = MaxStr;
            }
            if (doxterity > MaxDox)
            {
                Console.WriteLine($"Максимальное значение ловкости {MaxDox}");
                this.doxterity = MaxDox;
            }
            if (doxterity < MinDox)
            {
                Console.WriteLine($"Минимальное значение ловкости {MinDox}");
                this.doxterity = MinDox;
            }
            if (strength < MinStr)
            {
                Console.WriteLine($"Минимальное значение силы {MinStr}");
                this.strength = MinStr;
            }
        }

    }
}
