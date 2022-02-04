using System;
using System.Collections.Generic;
using System.Text;
using _0302.Unit;
using _0302.InterfaceWeapon;

namespace _0302.House
{
    class PostHouse : IThrowableWeapon
    {
        public int Damage => 0;

        public int Durability => throw new NotImplementedException();

        public void Hit()
        {
            throw new NotImplementedException();
        }

        public void Repair()
        {
            throw new NotImplementedException();
        }
    }
}
