using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount
            {
                Ballance = 1200,
                id = "12314dc",
                Percent = 0.057
            };
            Employee employee = new Employee
            {
                EName = "Tom",
                k = 1.7,
                min = 15000
            };
            Client client = new Client
            {
                CName = "Bob",
                Login = "Bob123",
                Password = "12344556677"
            };
            Console.WriteLine("Добро пожаловать, клиент");
            Console.WriteLine($"Ваш id: {bank.id}", bank.id);
            Operations.ShowEmployee(employee);
            Operations.Salary(employee, 15000, 1.7);
            Operations.ShowClient(client);
            Operations.Transaction(bank, bank, 100);
            Operations.Withdraw(bank, 100);
            Operations.Calculate(bank);
            Operations.GetCredit(bank);
            Operations.ShowBallance(bank);
        }
    }
}
