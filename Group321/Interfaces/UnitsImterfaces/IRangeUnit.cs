using Group321.Interfaces.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.Interfaces.UnitsImterfaces
{
    interface IRangeUnit : IUnit
    {
        public double Range { get; set; }

        public void Throw(IThrowableWeapon weapon);

        public void Shoot(IrangeWeapon weapon);
    }
}