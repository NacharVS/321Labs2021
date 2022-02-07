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
            Post post = new Post();
            post.NewHealth = 100;
            post.NewDamage = 14;
            post.NewDefence = 20;
            shaman1.BuffDamage = 50;
            shaman1.BuffHealth = 50;
            shaman1.BuffDefence = 30;
            archer1.NewHealth = archer.Health - ((archer1.Health / 100) * shaman1.BuffHealth);
            archer1.NewDamage = archer1.Damage * (shaman1.BuffDamage + 100) / 100;
            archer1.NewDefence = archer1.Defence * (shaman1.BuffDefence + 100) / 100;

            Task[] tasks1 = new Task[4]
            {
                new Task(() => post.JoinTheArmy()),
                new Task(() => post.Action()),
                new Task(() => post.Create()),
                new Task(() => post.Move())
            };
            tasks1[0].Start();
            tasks1[0].Wait();
            tasks1[1].Start();
            tasks1[1].Wait();
            tasks1[2].Start();
            tasks1[2].Wait();
            tasks1[3].Start();
            tasks1[3].Wait();

            Task[] tasks2 = new Task[5]
            {
                new Task(() => archer1.Move()),
                new Task(() => shaman1.BerserkBuff()),
                new Task(() => archer1.ArcherBuffed()),
                new Task(() => archer1.Fire()),
                new Task(() => archer1.Characteristic())
            };
            tasks2[0].Start();
            tasks2[0].Wait();
            tasks2[1].Start();
            tasks2[1].Wait();
            tasks2[2].Start();
            tasks2[2].Wait();
            tasks2[3].Start();
            tasks2[3].Wait();
            tasks2[4].Start();
            tasks2[4].Wait();

        }
    }
}
