using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Units
{
    class Toverna
    {
        public Archer MakeArcher()
        {
            Console.WriteLine("Создан новый ЛУЧНИК!");
            return new Archer();
        }

        public PhantomAssasin MakeQuack()
        {
            Console.WriteLine("Создан новый ШАМАН!");
            return new PhantomAssasin();
        }

        public Soldier MakeSoldier()
        {
            Console.WriteLine("Создан новый СОЛДАТ!");
            return new Soldier();
        }
        public Svinger MakeSvinger()
        {
            Console.WriteLine("Создан новый СВИНГЕР");
            return new Svinger();
        }
    }
}
