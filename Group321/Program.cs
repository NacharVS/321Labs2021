using Group321.Examples;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Group321
{
    class Program
    {
        delegate void MessageDelegate(string message);

        static void Main(string[] args)
        {
            int[] array = new int[10];
            Task taskGen = new Task(() => Generation(array));
            Task taskSumm = new Task(() => Summ(array));
            taskGen.Start();
            taskGen.Wait();
            taskSumm.Start();
            
        }

        static void Generation(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(20);
                Console.Write(array[i] + " ");
            }
        }

        static void Summ(int[] array)
        {
            int summ = 0;
            foreach (var item in array)
            {
                summ += item;
            }
            Console.WriteLine();
            Console.WriteLine("summ" + summ);
        }

    }
}
