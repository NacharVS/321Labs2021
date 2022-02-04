using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.Interfaces
{
    class Tower
    {
        private Garrison garrison;
        public Tower(Garrison garrison)
        {
            this.garrison = garrison;
        }

        public void Attack()
        {
            garrison.Attack();
        }
    }
}
