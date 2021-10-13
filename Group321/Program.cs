using System;
using System.Threading;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте");
            Console.WriteLine("Ваше имя");
            string fname = Console.ReadLine();
            Console.WriteLine("Ваше фамилия?");
            string lname = Console.ReadLine();
            Console.WriteLine("Ваш номер телефона");
            string tnumber = Console.ReadLine();
            Console.WriteLine("Дата рождения");
            string birday = Console.ReadLine();
            PersonalDate client = new PersonalDate(fname, lname, tnumber, birday);
            client.GetPersonalData();

            Account acc = new Account();
            Account acc1 = new Account();
            acc.Balance = 10000;
            acc1.Balance = 2000;
            Operations.ShowBalance(acc);
            Operations.ShowBalance(acc1);

            Operations.Transaction(acc, acc1, 1000);

            Operations.Withdraw(acc, 1000);
            Operations.Deposit(acc, 2000, 3);
            Employee Ivanov = new Employee();

            Operations.Credit(Ivanov, 30000, 6, 500);
        }
    }
}