using System;
using Практика_интерфейсы.Warriors;
using Group321.InterfacesAgain.Warriors;

namespace Практика_интерфейсы
{
    class Program
    {
        delegate void MessageDelegate(string message);

        static void Main(string[] args)
        {

            //1. 3 юнита. Лучник, Шаман который накладывает бафы.  
            //2. 3 здания. 1 из зданий производит юнитов. 1 из зданий принимет гарнизон.  
            Soldier soldier = new Soldier("Ivan", 50, 120, 250, 30);
            Quack quack = new Quack("David", 10, 50, 150, 20);
            Archer archer = new Archer("Ilya",70,80,50,60);
            Anonimus anonimus = new Anonimus("Anatolii", 120, 20, 300, 100);
            Kazarma kazarma = new Kazarma();
            Blacksmith blacksmith = new Blacksmith();
            var Anonimus = kazarma.MakeAnonimus();
            quack.STONESKIN(quack);
            quack.STONESKIN(soldier);
            Console.WriteLine($"Имя знахаря:{quack.Name}  урон:{quack.Damage}  защита:{quack.Armor}  здоровье:{quack.Hp}  бегает:{quack.Run}");
            var knife = blacksmith.MakeKnife();
            var bow = blacksmith.MakeBow();
            var SyperKnife = blacksmith.MakeKnife();
            soldier.Blow(knife);
            soldier.Throw(knife);
            archer.Shoot(bow);
            anonimus.Throw(SyperKnife);
            quack.BERSERK(anonimus);
            Console.WriteLine($"Имя анонимуса:{anonimus.Name}  урон:{anonimus.Damage}  защита:{anonimus.Armor}  здоровье:{anonimus.Hp}  бегает:{anonimus.Run}");
            quack.ALLBAFSS(soldier);
            Console.WriteLine($"Имя солдата:{soldier.Name}  урон:{soldier.Damage}  защита:{soldier.Armor}  здоровье:{soldier.Hp}  бегает:{soldier.Run}");



            blacksmith.Repair(SyperKnife);
            blacksmith.Repair(knife);
        }

    }
}
