using Group321.InterfacesAgain;
using Piano.InterfacesGarrison.Class;
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

            //Soldier Victor = new Soldier();
            //Blacksmith Igor = new Blacksmith();
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
            //var knife = Igor.MakeKnife();
            //Victor.Blow(knife);
            //Victor.Throw(knife);
            //Igor.Repair(knife);



            ArcherUnit Ivan1 = new ArcherUnit();
            Pyromancer Ivan2 = new Pyromancer();
            Shaman Ivan3 = new Shaman();



            Ivan3.ConclusionBuffonArcherAtt(Ivan1);
            Ivan3.ConclusionBuffonPyromancerAtt(Ivan2);
            Ivan3.ConclusionBuffonArcherDef(Ivan1);
            Ivan3.ConclusionBuffonPyromancerDef(Ivan2);
        }



        //static int[] Generation(int[] array)
        //{
        //    Random rnd = new Random();
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = rnd.Next(2);
        //        Console.Write(array[i]+ " ");
        //    }
        //    return array;
        //}
        //static void Summ(int[] array, CancellationToken token)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        if (token.IsCancellationRequested)
        //        {
        //            Console.WriteLine("Operation has canceled");
        //            return;
        //        }

        //        Thread.Sleep(1000);
        //        int summ = 0;
        //        foreach (var item in array)
        //        {
        //            summ += item;
        //        }
        //        Console.WriteLine();
        //        Console.WriteLine("summ" + summ);
        //    }
            
        //}
        //static int[] doubleArray(int[] array, CancellationToken token)
        //{
        //    if (token.IsCancellationRequested)
        //    {
        //        Console.WriteLine("Operation has canceled");
        //        return null;
        //    }
        //    Thread.Sleep(10000);
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] *= 2;
        //    }
        //    return array;
        //}
    }
}
