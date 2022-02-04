using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_интерфейсы.WeaponsImpementatin
{
    public interface IRepairible /*Ремонтопригодный*/
    {
        int Durability { get; }
        void Repair();
    }
}
