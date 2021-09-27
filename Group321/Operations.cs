using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class Operations
    {
        public static void ShowBallance (BankAccount bankAccount)
        {
            Console.WriteLine($"Ваш баланс: {bankAccount.Ballance} ", bankAccount.Ballance);
        }

        public static void ShowListEmployee(Administrator administrator)
        {
            Console.WriteLine("Сoздание списка:\nList<Employee>");
            List<Employee> employees = new List<Employee>(5);
            employees.Add(new Employee() { EName = "Tom" });
            employees.Add(new Employee() { EName = "Bulat" });
            employees.Add(new Employee() { EName = "Shakira" });
            employees.Add(new Employee() { EName = "Vlad" });
            employees.Add(new Employee() { EName = "Rybak" });

            Console.WriteLine();
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.EName);
            }

            Console.WriteLine();
            Console.WriteLine("Проверка:\nContains(\"John\"): {0}",
            employees.Contains(new Employee { EName = "John" }));

            Console.WriteLine();
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.EName);
            }

            Console.WriteLine();
            Console.WriteLine("Добавление:\nInsert(2, \"Bob\")");
            employees.Insert(2, new Employee() { EName = "Bob" });

            Console.WriteLine();
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.EName);
            }

            Console.WriteLine();
            Console.WriteLine("Какой удалить:\nRemove(\"Tom\")");
            employees.Remove(new Employee() { EName = "Tom" });

            Console.WriteLine();
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.EName);
            }

            Console.WriteLine();
            Console.WriteLine("Удаление:\nRemoveAt(0)");
            employees.RemoveAt(0);

            Console.WriteLine();
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.EName);
            }

        }
        public static void ShowListClient(Administrator administrator)
        {
            Console.WriteLine("Сoздание списка:\nList<Client>");
            List<Client> clients = new List<Client>(5);
            clients.Add(new Client() { CName = "Iskander" });
            clients.Add(new Client() { CName = "Gizetdin" });
            clients.Add(new Client() { CName = "Sasha" });
            clients.Add(new Client() { CName = "Krasni" });
            clients.Add(new Client() { CName = "Talgat" });

            foreach (Client c in clients)
            {
                Console.WriteLine(c.CName);
            }

            Console.WriteLine();
            Console.WriteLine("Проверка:\nContains(\"Tom\"): {0}",
            clients.Contains(new Client { CName = "Tom" }));

            Console.WriteLine();
            foreach (Client c in clients)
            {
                Console.WriteLine(c.CName);
            }

            Console.WriteLine();
            Console.WriteLine("Добавление:\nInsert(4, \"John\")");
            clients.Insert(4, new Client() { CName = "John" });

            Console.WriteLine();
            foreach (Client c in clients)
            {
                Console.WriteLine(c.CName);
            }

            Console.WriteLine();
            Console.WriteLine("Какой удалить:\nRemove(\"Talgat\")");
            clients.Remove(new Client() { CName = "Talgat" });

            Console.WriteLine();
            foreach (Client c in clients)
            {
                Console.WriteLine(c.CName);
            }

            Console.WriteLine();
            Console.WriteLine("Удаление:\nRemoveAt(5)");
            clients.RemoveAt(5);

            Console.WriteLine();
            foreach (Client c in clients)
            {
                Console.WriteLine(c.CName);
            }

        }
    


        public static void ShowEmployee(Employee employee)
        {
            Console.WriteLine($"Ваше имя: {employee.EName} ", employee.EName);
        }

        public static void ShowClient(Client client)
        {
            Console.WriteLine($"Вашe имя: {client.CName}, " + $"Ваш логин: {client.Login}", client.CName, client.Login);
        }


        public static double Salary(Employee employee, double min, double k)
        {
            double result = 0;
            result =  min * k;
            Console.WriteLine($"Зарплата начисленная сотруднику: {result}", result);
            return min * k;
        }

        public static void Transaction(BankAccount bankAccount, BankAccount bankAccount1, double sum)       
        {
            bankAccount1.Ballance += sum;
            bankAccount.Ballance -= sum;
            Console.WriteLine($"Транзакция выполнена: {sum}", sum);
        }

        public static void Withdraw(BankAccount bankAccount, double sum)
        {
            double result = 0;
            if (bankAccount.Ballance >= sum)
            {
                bankAccount.Ballance -= sum;
                result = sum;
                Console.WriteLine($"Сумма {sum} снято со счета", sum);
            }
            else
            {
                Console.WriteLine("Недостаточно денег на счету");
            }
        }

        public static void Calculate(BankAccount bankAccount)
        {
            double increment = bankAccount.Ballance * bankAccount.Percent / 100;
            bankAccount.Ballance = bankAccount.Ballance + increment;
            Console.WriteLine($"Начислены проценты в размере: {increment}", increment);
        }

        public static void GetCredit(BankAccount bankAccount)
        {
            double creditSum = 3000;
            bankAccount.Ballance = bankAccount.Ballance - creditSum;
            double indebtedness = 0;
            double overpay = 0;

            if (bankAccount.Ballance > creditSum)
            {
                overpay = bankAccount.Ballance - creditSum;
                Console.WriteLine($"Кредит погашен");
                Console.WriteLine($"Переплата по ставке: {overpay}", overpay);
            }
            else if (bankAccount.Ballance == creditSum)
            {
                Console.WriteLine($"Кредит погашен");
            }
            else
            {
                indebtedness  = creditSum - bankAccount.Ballance;
                Console.WriteLine($"Задолжность составляет: {indebtedness}", indebtedness);
            }

        }

    }
}
