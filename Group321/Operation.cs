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
        public static int Credit(Account acc, double CreditStavka  , double sum)
        {
            int mounth = Convert.ToInt32(Console.ReadLine());
            acc.Balance += sum;
            acc.CreditSher = (sum + CreditStavka / 12) * mounth;
            return (int)acc.CreditSher;
        }
    }
    class Iformation
    {
        public static List<PersonalData> lbd;   
        public static void StartProgramm()
        {
            lbd = new List<PersonalData>();
            lbd.Add(new PersonalData("Иванов Иван Иванович", "Москва", new Employee(30000)));
            lbd.Add(new PersonalData("Богословский Артем Михайлович", "Москва", new Client(25000)));
            lbd.Add(new PersonalData("Ардаков Игорь Герасимович", "Москва", new Client(35000)));
            lbd.Add(new PersonalData("Донченко Иван Андреевич", "Москва", new Employee(20000)));
            lbd.Add(new PersonalData("Кулагина Юлия Анатольевна", "Москва", new Client(27000)));
            lbd.Add(new PersonalData("Девин Игорь Владимирович", "Москва", new Employee(34000)));
            lbd.Add(new PersonalData("Логинова Галина Васильевна", "Москва", new Client(19000)));
            lbd.Add(new PersonalData("Логинов Сергей Николаевич", "Москва", new Employee(22000)));
            lbd.Add(new PersonalData("Беляев Михаил Викторович", "Москва", new Client(43000)));
            lbd.Add(new PersonalData("Шалдыбин Дмитрий Игоревич", "Москва", new Employee(63000)));
        }
        static void Main(string[] args)
        {
            StartProgramm();
            Operation.Dob(lbd);
            Operation.ShowList(lbd);
            Account acc1 = new Client(15000);
            Account acc2 = new Employee(9000);
            Console.WriteLine(acc1.Balance + "Р. Счёт первого аккаунта");
            Console.WriteLine(acc2.Balance + "Р. Счёт второго аккаунта");
            Operation.Widthraw(acc1, 1000);
            Operation.Deposit(acc1, 2000);
            Operation.Transaction(acc1, acc2, 10000);
            Console.WriteLine("Сумма кредита");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Сумма кредита = {Operation.Credit(acc1, acc1.CreditStavka, sum)} Баланс аккаунта ={acc1.Balance}");

        }
    }
}
