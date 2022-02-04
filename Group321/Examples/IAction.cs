using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense.Examples
{
    interface IAction
    {
       public int Health { get; set; }

       public int Damage { get; set; }


        void Move();
        void Action();

        void Characteristic();
    }
}
