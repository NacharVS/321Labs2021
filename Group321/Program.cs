using System;
using System.Threading;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Переведи 500р на этот номер 89625574949 в течении 5 минут или мы сольем твои голые фотки");
             for(int i = 1; i <= 10; ++i)
             {
                 string msg = $"Бабай откинулся через {i}/10 \n";
                 foreach (char letter in msg)
                 {
                     Console.Write(letter);
                     Thread.Sleep(100);
                 }

             }
             Console.WriteLine("Процесс обнал запущен"); */

            Console.WriteLine("Welcome");
            Console.WriteLine("Your first name?");
            string fn = Console.ReadLine();
            Console.WriteLine("Your last name?");
            string ln = Console.ReadLine();
            Console.WriteLine("Your telephone number?");
            string tnumber = Console.ReadLine();
            Console.WriteLine("Your date of birthday?");
            string bday = Console.ReadLine();
            PersonalDate client = new PersonalDate(fn, ln, tnumber, bday);
            client.GetPersonalData();

            Account acc = new Account();
            Account acc2 = new Account();
            acc.Balance = 2000;
            acc2.Balance = 7000;
            Operations.ShowBalance(acc);
            Operations.ShowBalance(acc2);

            Operations.Transaction(acc, acc2, 500);

            Operations.Withdraw(acc, 600);
            Operations.Deposit(acc, 800, 4);
            Employee marsel = new Employee();

            Operations.Credit(marsel, 30000, 6, 500);
        }
    }
}
