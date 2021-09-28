using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.Examples
{
    interface IAction
    {
        int Health { get; set; }
        void Move();
        void Action();
    }
}
