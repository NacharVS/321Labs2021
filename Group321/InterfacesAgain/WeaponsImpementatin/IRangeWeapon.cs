using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_интерфейсы.WeaponsImpementatin
{
    interface IrangeWeapon /*ДиапазонОружия*/ : IRepairible
    {
        int range { get; }
    }
}
