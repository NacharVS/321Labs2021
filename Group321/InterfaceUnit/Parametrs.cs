using System;
using System.Collections.Generic;
using System.Text;
using _0302.InterfaceWeapon;
using _0302.House;

namespace _0302.InterfaceUnit
{
    interface Parametrs
    {
        int healf { get; } 
        int berserk { get; }
        int defense { get; }
        int speed { get; }

        void Par();

        void Fury();
       
    }
}
