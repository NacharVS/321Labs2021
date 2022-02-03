using Group321.Interfaces;
using Group321.Interfaces.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.Interface
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
