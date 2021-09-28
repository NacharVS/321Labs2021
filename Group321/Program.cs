using Group321.Examples;
using System;

namespace Group321
{
    class Program
    {
        delegate void MessageDelegate(string message);

        static void Main(string[] args)
        {
            IAction psnt = new Peasant(30);
            psnt.Action();

        }
        static void Death()
        {
            Console.WriteLine("Is dead");
        }

        static void ShowInfo(string info)
        {
            Console.WriteLine(info);
        }
    }
}
