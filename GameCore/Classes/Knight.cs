using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Classes
{
    public class Knight : Human
    {
        public Knight(string Name) : base(Name)
        {
            CountStats();
        }

        public Knight(string Name, int Strength, int Dexterity, int Intellect) : base(Name, Strength, Dexterity, Intellect)
        {
            CountStats();
        }

        protected override void CountStats()
        {
            if (HP < 500 || RegenHP < 50)
            {
                HP = Strength * 20;
                RegenHP = Strength * 0.1;
            }

            if (Armor < 90 || SpeedAttack < 90)
            {
                Armor = Dexterity * 0.17;
                SpeedAttack = Dexterity * 1;
            }

            if (Mana < 300 || RegenMana < 60)
            {
                Mana = Intellect * 12;
                RegenMana = Intellect * 0.5;
            }
        }

        public override void GoWork()
        {
            Console.WriteLine($"Благородный {Name} отправился совершать подвиги!");
        }

        public override void GoEat()
        {
            Console.WriteLine($"Благородный {Name} пирствует в замке короля!");
        }
    }
}
