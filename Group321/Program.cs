using System;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            double rate = double.Parse(Console.ReadLine());

            int mounthCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < mounthCount; i++)
            {
                balance = balance + balance * rate;
            }
            Console.WriteLine($"ur ballance {balance} after {mounthCount} mounths");


        }
    }
}
