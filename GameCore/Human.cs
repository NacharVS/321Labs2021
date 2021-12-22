using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    abstract public class Human
    {
        protected string Name;
        public virtual string Nickname { get; set; }

        protected double HP;
        protected double Mana;
        protected double Armor;

        protected double RegenHP;
        protected double RegenMana;

        protected double SpeedAttack;

        protected double Strength;
        protected double Dexterity;
        protected double Intellect;

        public Human(string Name)
        {
            this.Name = Name;
            HP = Mana = 20;
            Strength = Dexterity = Intellect = 20;
            CountStats();
        }

        public Human(string Name, int Strength, int Dexterity, int Intellect)
        {
            this.Name = Name;
            HP = Mana = 20;

            if(Strength <= 10 || Dexterity <= 10 || Intellect <= 10)
            {
                this.Strength = Strength;
                this.Dexterity = Dexterity;
                this.Intellect = Intellect;
                CountStats();
            }
            else
            {
                Console.WriteLine("Атрибуты не могут быть меньше 10!");
                return;
            }
        }

        protected virtual void CountStats()
        {
            if (HP < 300 || RegenHP < 60)
            {
                HP = Strength * 20;
                RegenHP = Strength * 0.1;
            }

            if(Armor < 50 || SpeedAttack < 80)
            {
                Armor = Dexterity * 0.17;
                SpeedAttack = Dexterity * 1;
            }

            if(Mana < 300 || RegenMana < 60)
            {
                Mana = Intellect * 12;
                RegenMana = Intellect * 0.5;
            }
        }

        public virtual void GoWork()
        { }

        public virtual void GoEat()
        { }

        public virtual void GetBiography()
        {
            Console.WriteLine($"{Name} {HP} HP {Mana} Mana \n {RegenHP} RegenHP {RegenMana} RegenMana \n {Armor} Armor {SpeedAttack} SpeedAttack \n {Strength} Strength {Dexterity} Dexterity {Intellect} Intellect");
        }
    }
}
