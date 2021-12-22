using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Hero
    {
        protected double strength = 20;
        protected double doxterity = 20;
        protected double pAttack = 0;
        public double Strength { get => strength; set => strength = value; }
        public double Doxterity { get => doxterity; set => doxterity = value; }
        public double PAttack { get => pAttack; set => pAttack = value; }

        public Hero(double strength, double doxterity)
        {
            this.strength = strength;
            this.doxterity = doxterity;
            pAttack = strength * 5 + doxterity;
        }

    }
}
