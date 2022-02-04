using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense.Examples
{
    interface IAction
    {
        public int Health { get; }

        public int Damage { get; }

        public int Defence { get; }

        public int NewHealth { get; set; }

        public int NewDamage { get; set; }

        public int NewDefence { get; set; }

        public int BuffDamage { get; set; }

        public int BuffHealth { get; set; }

        public int BuffDefence { get; set; }

        void Move();
        void Action();

        void Characteristic();
    }
}
