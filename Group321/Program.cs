using Group321.InterfacesAgain;
using Group321.InterfacesAgain.Units;
using Group321.InterfacesAgain.Weapons;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Group321
{
    class Program : Barracks
    {
        delegate void MessageDelegate(string message);

        static void Main(string[] args)
        {

            //1. 3 юнита. Лучник, Шаман который накладывает бафы.  
            //2. 3 здания. 1 из зданий производит юнитов. 1 из зданий принимет гарнизон.  
            Shaman Victor = new Shaman();
            Blacksmith Igor = new Blacksmith();
            Soldier Anna = new Soldier();
            Victor.SoldierBuff();
            //var weapon2 = Igor.MakeAxe();
            //Victor.weapon = weapon2;
            //Victor.weapon.Hit();
            //var weapon3 = Igor.MakeSword();
            //Victor.weapon = weapon3;
            //Igor.Repair(weapon4);

        }

        static int[] Generation(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2);
                Console.Write(array[i]+ " ");
            }
            return array;
        }

        static void Summ(int[] array, CancellationToken token)
        {
            for (int i = 0; i < 10; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Operation has canceled");
                    return;
                }

                Thread.Sleep(1000);
                int summ = 0;
                foreach (var item in array)
                {
                    summ += item;
                }
                Console.WriteLine();
                Console.WriteLine("summ" + summ);
            }
            
        }

        static int[] doubleArray(int[] array, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Operation has canceled");
                return null;
            }
            Thread.Sleep(10000);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
            return array;
        }

    }
}
