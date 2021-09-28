using System;
using BankCore;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations.Start();

            BankAccount account = new BankAccount();
            account.Ballance = 1000;

            BankAccount account2 = new BankAccount();
            account.Ballance = 2000;

            Operations.ShowBallance(account);
            Operations.Transaction(account, account2, 500);

            Operations.Deposit(account2, 10);
            Operations.ShowBallance(account2);

            PersonalData pd = new PersonalData("Ivan", "Ivanov", 21, 800800);
            pd.PersonalInfo();

            Employee emp = new Employee("Chuck", "Norris", 21, 800800, "Bodyguard");
            emp.PersonalInfo();
        }
    }
}
