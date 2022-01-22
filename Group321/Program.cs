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
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            int[] array = new int[10];
            //Task<int[]> taskGen = new Task<int[]>(() => Generation(array));
            Task task2 = new Task(() => Summ(array, token));

            //Task<int[]> task2 = taskGen.ContinueWith(doublearr => doubleArray(doublearr.Result, token));

            //taskGen.Start();
            task2.Start();
            string cancelRequest = Console.ReadLine();

            if(cancelRequest == "Y")
            {
                tokenSource.Cancel();
            }         
            

    
            //int buff = 0;

            //foreach (var item in task2.Result)
            //{
            //    buff += item;
            //}
            //Console.WriteLine(buff);


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
