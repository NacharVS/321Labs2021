using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense.Examples
{
    interface IArcherAction
    {
        int Range { get; }

        void Fire();
    }
}
