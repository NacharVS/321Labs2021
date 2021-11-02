using Group321.Examples;
using System;

namespace Group321
{
    class Program
    {
        delegate void MessageDelegate(string message);

        static void Main(string[] args)
        {
            //Mongo.UpdateName(new Mongo("Olegek", 16, 311));
            Mongo.UpdateName(18);
            //Mongo.FindFromDatabase();

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
