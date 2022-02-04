using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_интерфейсы.WeaponsImpementatin
{
    public interface IThrowableWeapon /*Метательное оружие*/ : IRepairible
    {
        int Damage { get; }

        void Hit();
    }
}
