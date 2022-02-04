using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практика_интерфейсы.WeaponsImpementatin;
using Практика_интерфейсы.Weapons;

namespace Практика_интерфейсы.Warriors
{
    class Blacksmith
    {
        public StoneAxe MakeAxe()
        {
            return new StoneAxe();
        }

        public ShortSword MakeSword()
        {
            return new ShortSword();
        }

        public Bow MakeBow()
        {
            return new Bow();
        }

        public Knife MakeKnife()
        {
            return new Knife();
        }

        public void Repair(IRepairible item)
        {
            item.Repair();
        }
    }
}
