using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    class Shaman : Units
    {
        static public void BaffBerserk()
        {
            health += health * 0.5;
            protection -= protection * 0.5;
        }
        
        static public void BaffStoneSkin()
        {
            protection += protection * 0.3;
            health += health * 0.2;
            speed -= speed * 0.4;
        }
        static public void BaffRescue()
        {
            health = 100;
        }
    }
}
