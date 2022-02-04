using System;
using System.Collections.Generic;
using System.Text;
using _0302.Unit;
using _0302.InterfaceWeapon;
using _0302.InterfaceUnit;

namespace _0302.House
{
    class PostHouse : IThrowableWeapon, Parametrs
    {
        public int Damage => 0;

        public int Durability => throw new NotImplementedException();

        public int healf => throw new NotImplementedException();

        public int berserk => throw new NotImplementedException();

        public int defense => throw new NotImplementedException();

        public int speed => throw new NotImplementedException();

        public int sumunit => throw new NotImplementedException();


        public void Hit()
        {
            throw new NotImplementedException();
        }

        public void Repair()
        {
            throw new NotImplementedException();
        }


        public void Par()
        {
            throw new NotImplementedException();
        }

        
    }
}
