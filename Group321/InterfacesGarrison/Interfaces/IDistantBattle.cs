﻿using Piano.InterfacesGarrison;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesGarrison.Interfaces
{
    interface IDistantBattle : IHeroes
    {
        int Range { get; }
    }
}
