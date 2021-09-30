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

            Employee employee = new Employee
            {
                idAccount = "0001",
                FullName = "Петров А.А.",
                Telephone = 89392841222,
                Salary = 20000,
                Ballance = 1500,
                Percent = 0.65
            };

            Client client = new Client
            {
                idAccount = "1000",
                FullName = "Гизетдинов И.Л.",
                Telephone = 89392847111,
                Password = "1234QWERT",
                Ballance = 450000,
                Percent = 0.1
            };

            Console.WriteLine("Выберите пункт");
            Console.WriteLine("1 Зайти на счет cотрудника");
            Console.WriteLine("2 Зайти на счет клиента");
            Console.WriteLine("   ");

            string qwe = Console.ReadLine();

            switch (qwe)
            {
                case "1":
                    Console.WriteLine("Сотрудник, добро пожаловать!");
                    Operations.ShowEmployee(employee);
                    break;
                case "2":
                    Console.WriteLine("Клиент, добро пожаловать!");
                    Operations.ShowClient(client);
                    break;





                    //switch ()
                    //   case "1":
                    //          Console.WriteLine("Ваш ID:"+ );
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //   case "2":
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //   case "3":
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //   case "4":
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //   case "5":
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //   case "6":
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //   case "7":
                    //          Console.WriteLine();
                    //          Console.WriteLine();
                    //          Console.WriteLine();
            }
        }
    }
}
