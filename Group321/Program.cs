using TowerDefense.Examples;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Group321
{
    class Program
    {
        delegate void MessageDelegate(string message);



        static void Main(string[] args)
        {

            //1. 3 юнита. Лучник, Шаман который накладывает бафы.  
            //2. 3 здания. 1 из зданий производит юнитов. 1 из зданий принимет гарнизон.  
            Archer archer1 = new Archer();
            Shaman shaman1 = new Shaman();
            Archer archer = new Archer();
            shaman1.BuffDamage = 50;
            shaman1.BuffHealth = 50;
            shaman1.BuffDefence = 30;
            archer1.NewHealth = archer.Health - ((archer1.Health / 100) * shaman1.BuffHealth);
            archer1.NewDamage = archer1.Damage + ((archer1.Damage / 100) * shaman1.BuffDamage);

            archer1.Fire();
            shaman1.BerserkBuff();
            archer1.ArcherBuffed();
            archer1.Characteristic();
        }
    }
}
