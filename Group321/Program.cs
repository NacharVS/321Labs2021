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
            List<Employee> employees = new List<Employee>(5);
            employees.Add(new Employee() { EName = "Tom"});
            employees.Add(new Employee() { EName = "Bulat" });
            employees.Add(new Employee() { EName = "Shakira" });
            employees.Add(new Employee() { EName = "Vlad" });
            employees.Add(new Employee() { EName = "Rybak" });

            foreach(Employee e in employees)
            {
                Console.WriteLine(e.EName);
            }

            employees.RemoveAt(4);

            List<Client> clients = new List<Client>(5);
            clients.Add(new Client() { CName = "Iskander" });
            clients.Add(new Client() { CName = "Gizetdin" });
            clients.Add(new Client() { CName = "Sasha" });
            clients.Add(new Client() { CName = "Krasni" });
            clients.Add(new Client() { CName = "Talgat" });

            clients.RemoveAt(4);
            BankAccount bank = new BankAccount
            {
                Ballance = 4200,
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
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("1) Зайти в аккаунт клиента");
                Console.WriteLine("2) Зайти в аккаунт сотрудника");
                String str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        Operations.ShowClient(client);
                        Console.WriteLine("Добро пожаловать, клиент");
                        Console.WriteLine($"Ваш id: {bank.id}", bank.id);
                        Console.WriteLine("3) Показать баланс");
                        Console.WriteLine("4) Провести транзакцию");
                        Console.WriteLine("5) Снять деньги");
                        Console.WriteLine("6) Взять кредит");
                        Console.WriteLine("0) Выход");
                        string str1 = Console.ReadLine();
                        if (str1 == "3")
                        {
                            goto case "3";
                        }
                        else if (str1 == "4")
                        {
                            goto case "4";
                        }
                        else if (str1 == "5")
                        {
                            goto case "5";
                        }
                        else if (str1 == "6")
                        {
                            goto case "6";
                        }
                        else if (str1 == "0")
                        {
                        goto case "0";
                        }
                        else
                        {
                            Console.WriteLine("Ошибка");
                        }
                        goto case "1";
                   case "2":
                        Operations.ShowEmployee(employee);
                        Console.WriteLine("Добро пожаловать, сотрудник");
                        Console.WriteLine($"Ваш id: {bank.id}", bank.id);
                        Console.WriteLine("a) Просмотр начисления зарплаты");
                        Console.WriteLine("0) Выход");
                        string str2 = Console.ReadLine();
                        if (str2 == "a")
                         {
                        goto case "a";
                        }
                        else if (str2 == "0")
                        {
                        goto case "0";
                        }
                        else
                        {
                        Console.WriteLine("Ошибка");
                        }
                        break;
                        

                    case "3":
                        Operations.ShowBallance(bank);
                        goto case "1";

                    case "4":
                        Operations.Transaction(bank, bank, 100);
                        goto case "1";

                    case "5":
                        Operations.Withdraw(bank, 100);
                        goto case "1";

                    case "6":
                        Operations.GetCredit(bank);
                        Operations.Calculate(bank);
                        goto case "1";
                    case "a":
                        Operations.Salary(employee, 15000, 1.7);
                        goto case "2";

                    case "0":
                        Console.WriteLine("Завершение обслуживания....");
                        return;
                }
        }
    }
}
