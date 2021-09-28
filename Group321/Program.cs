using System;
using BankCore;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            Test tst = new Test();
            tst.Start();

            while (true)
            {
                Console.WriteLine($"\tPress '1' to make a new profile\n\tPress '2' to take info about us\n\tPress '3' to exit");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1": 
                        PersonalData pd = new PersonalData("Ivan", "Ivanov", 21, 800800);
                        Console.WriteLine(pd);
                        break;

                }
            }

            //PersonalData pd = new PersonalData("Ivan", "Ivanov", 21, 800800);
            //pd.PersonalInfo();

            //Employee emp = new Employee("Chuck", "Norris", 21, 800800, "Bodyguard");
            //emp.PersonalInfo();

            //BankAccount account = new BankAccount(pd);
            //account.Ballance = 1000;

            //BankAccount account2 = new BankAccount(emp);
            //account.Ballance = 2000;

            //Operations.ShowBallance(account);
            //Operations.Transaction(account, account2, 500);

            //Operations.Deposit(account2, 10);
            //Operations.ShowBallance(account2);
        }
    }
}
