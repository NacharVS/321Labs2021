using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
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
    }
}
