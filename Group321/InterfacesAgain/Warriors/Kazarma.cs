using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практика_интерфейсы.WeaponsImpementatin;
using Практика_интерфейсы.Weapons;
using Group321.InterfacesAgain.Warriors;

namespace Практика_интерфейсы.Warriors
{
    class Kazarma
    {
        public Archer MakeArcher()
        {
            Console.WriteLine("Создан новый ЛУЧНИК!");
            return new Archer();
        }

        public Quack MakeQuack()
        {
            Console.WriteLine("Создан новый ШАМАН!");
            return new Quack();
        }

        public Soldier MakeSoldier()
        {
            Console.WriteLine("Создан новый СОЛДАТ!");
            return new Soldier();
        }
        public Anonimus MakeAnonimus()
        {
            Console.WriteLine("Создан новый Анонимус!");
            return new Anonimus();
        }
    }
}
