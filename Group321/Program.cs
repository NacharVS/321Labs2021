using System;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            Account bank = new Account
            {
                idAccount = "123",
                Telephone = 89392847361,
                Ballance = 15000,
                Percent = 0.9
            };

            Console.WriteLine("Выберите пункт");
            Console.WriteLine("1 Зайти на счет cотрудника");
            Console.WriteLine("2 Зайти на счет cотрудника");

            string qwe = Console.ReadLine();

            switch (qwe)
            {
                case "1":
                    Console.WriteLine("Сотрудник, добро пожаловать!");
                    break;
                case "2":
                    Console.WriteLine("Клиент, добро пожаловать!");
                    break;
            }
        }
    }
}
