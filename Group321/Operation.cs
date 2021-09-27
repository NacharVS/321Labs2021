using Group321;
using System;
using System.Collections.Generic;
using System.Text;


namespace bank1
{
     class Operation
    {
        public static void ShowList(List<PersonalData> lbd)
        {
                foreach (var item in lbd)
            {
                Console.WriteLine(item.FIO + ", " + item.Adress + ", " + item.account.ToString());
            }
        }
        public static void Dob(List<PersonalData> lbd)
        {
            Console.WriteLine("Введите ваше Имя");
            string FIO = Console.ReadLine();
            Console.WriteLine("Введите ваш адрес");
            string Adress = Console.ReadLine();
            Console.WriteLine("Введите Client or Employee");
            switch (Console.ReadLine())
            {
                case "Client":
                    lbd.Add(new PersonalData(FIO, Adress, new Client()));
                    break;
                case "Employee":
                    lbd.Add(new PersonalData(FIO, Adress, new Employee()));
                    break;
            }
        }
            public static void ShowBalance(Account acc)
        {
            Console.WriteLine(acc.Balance);
        }
        public static void Transaction(Account acc, Account acc1, double sum)
        {
            acc.Balance -= sum;
            acc1.Balance += sum;
            Console.WriteLine("Транзакция выполнена!");
        }
        public static int Widthraw(Account account, double sum)
        {
            if (sum % 1 < 1)
            {
                account.Balance -= sum;
                Console.WriteLine("Сумма списания:" +  sum , "Руб!");
                Console.WriteLine("Баланс после списания:" +  account.Balance , "Руб!");
            }
            return 0;
        }
        public static int Deposit(Account accountgetter, double sum)
        {
            accountgetter.Balance += sum;
            Console.WriteLine("Депозит прошёл успшно!");
            return 0;
        }
        public static int Credit(Account acc2, double CreditStavka, double kolvodney, double sum)
        {
            acc2.Balance += sum;
            acc2.Zadoljnost += (int)(sum * (CreditStavka / 100 * kolvodney));
            Console.WriteLine("Кредит прошёл успешно");
            Console.WriteLine($"Баланс 2-ого аккаунта: - {acc2.Balance}");
            Console.WriteLine($"Задолжность 2-ого аккаунта: - {acc2.Balance}");
            return (int) sum;
        }
    }
    class Iformation
    {
        public static List<PersonalData> ldb;   
        public static void StartProgramm()
        {
            ldb = new List<PersonalData>();
            ldb.Add(new PersonalData("Иванов Иван Иванович", "Москва", new Employee(30000)));
            ldb.Add(new PersonalData("Богословский Артем Михайлович", "Москва", new Employee(30000)));
            ldb.Add(new PersonalData("Ардаков Игорь Герасимович", "Москва", new Employee(30000)));
            ldb.Add(new PersonalData("Донченко Иван Андреевич", "Москва", new Employee(30000)));
            ldb.Add(new PersonalData("Кулагина Юлия Анатольевна", "Москва", new Employee(30000)));
            ldb.Add(new PersonalData("Девин Игорь Владимирович", "Москва", new Employee(30000)));
            ldb.Add(new PersonalData("Иванов Иван Иванович", "Москва", new Employee(30000)));
            ldb.Add(new PersonalData("Иванов Иван Иванович", "Москва", new Employee(30000)));
            ldb.Add(new PersonalData("Иванов Иван Иванович", "Москва", new Employee(30000)));
            ldb.Add(new PersonalData("Иванов Иван Иванович", "Москва", new Employee(30000)));
        }
    }
}
