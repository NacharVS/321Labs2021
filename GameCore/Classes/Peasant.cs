using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Classes
{
    public class Peasant : Human
    {
        public Peasant(string Name) : base(Name)
        {
            CountStats();
        }

        public Peasant(string Name, int Strength, int Dexterity, int Intellect) : base(Name, Strength, Dexterity, Intellect)
        {
            CountStats();
        }

        protected override void CountStats()
        {
            if (HP < 150 || RegenHP < 30)
            {
                HP = Strength * 20;
                RegenHP = Strength * 0.1;
            }

            if (Armor < 50 || SpeedAttack < 40)
            {
                Armor = Dexterity * 0.17;
                SpeedAttack = Dexterity * 1;
            }

            Mana = 0;
            RegenMana = 0;
        }

        public override void GoWork()
        {
            Console.WriteLine($"Крестьянин {Name} пошел корпатиться на ферму!");
        }

        public override void GoEat()
        {
            Console.WriteLine($"Крестьянин {Name} грызет сырой картофель...");
        }

    }
}
