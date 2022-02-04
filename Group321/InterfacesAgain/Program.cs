using System;
using Практика_интерфейсы.Warriors;

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
            Blacksmith blacksmith = new Blacksmith();
            Quack quack = new Quack("David", 10, 50, 150, 20);
            //Victor.weapon.Hit();

            //var weapon2 = Igor.MakeAxe();
            //Victor.weapon = weapon2;
            //Victor.weapon.Hit();
            //var weapon3 = Igor.MakeSword();
            //Victor.weapon = weapon3;
            //var weapon4 = Igor.MakeBow();
            //Victor.weapon = weapon4;
            //Victor.weapon.Hit();
            //Igor.Repair(weapon4);

            //David.BERSERK(David);
            quack.STONESKIN(quack);
            quack.STONESKIN(soldier);
            Console.WriteLine($"Имя знахаря:{quack.Name}  урон:{quack.Damage}  защита:{quack.Armor}  здоровье:{quack.Hp}  бегает:{quack.Run}");
            var knife = blacksmith.MakeKnife();
            soldier.Blow(knife);
            soldier.Throw(knife);


            blacksmith.Repair(knife);
        }

    }
}
