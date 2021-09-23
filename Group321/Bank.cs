using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Operations
    {
        public static void ShowList(List<PersonalData> lst)
        {
            foreach (var item in lst)
            {
                Console.WriteLine(item.FIO+", "+item.addres+", "+item.account.ToString()); 
            }
        }
        public static void Dobavleniye(List<PersonalData> lst)
        {
            Console.WriteLine("Введите ваше ФИО");
            string FIO = Console.ReadLine();
            Console.WriteLine("Введите ваш адрес");
            string addres = Console.ReadLine();
            Console.WriteLine("Вы сотрудник или клиент?Введите Employee or Client");
            switch(Console.ReadLine())
            {
                case "Client" :
                    lst.Add(new PersonalData( FIO,  addres, new Client()));
                    break;
                case "Employee":
                    lst.Add(new PersonalData(FIO, addres, new Employee()));
                    break;

            }
            //lst.Add(new PersonalData("Баринов Марсель Алексеевич", "Казань", new Employee(20000)));
            //lst.Add(new PersonalData("", "Казань", new Employee(20000)));
        }
        public static void ShowBalance(Account account)
        {
            Console.WriteLine(account.Balance);
        }
        public static void Transaction(Account accountSeller, Account accountGetter, double sum)
        {
            if (accountGetter.Balance >= sum && accountSeller.Balance >= sum)
            {
                Console.WriteLine("Транзакция успешна!");
                accountSeller.Balance -= sum;
                accountGetter.Balance += sum;
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.WriteLine("Баланс первого аккаунта: " + accountSeller.Balance + ' ' + " Баланс второго аккаунта: " + accountGetter.Balance);
        }
        public static int Widthdraw(Account account, double sum)
        {
            if (sum % 1 < 1)
            {
                account.Balance -= sum;
                Console.WriteLine("Сумма списания: " + sum + "руб!");
                Console.WriteLine("Баланс после списания: " + account.Balance + "руб!");
            }
            else
            {
                Console.WriteLine("Error!");
            }
            return 0;

        }
        public static int Deposit(Account accountGetter, double sum)
        {
            accountGetter.Balance += sum;
            Console.WriteLine("Операция депозита проведена успешно!");
            return 0;
        }

        public static double Credit(Account account, double CreditStavka, double sum)
        {
            int mounthCount = Convert.ToInt32(Console.ReadLine());
            account.Balance += sum;
            account.CreditShet = (sum + CreditStavka / 12) * mounthCount;
            return account.CreditShet;


        }
        
    }

    class ProgramBalance
    {
         public  static List<PersonalData> lst;
        public static void StartProgram()
        {
            lst = new List<PersonalData>();
            lst.Add(new PersonalData("Краснов Александр Грирьевич", "Казань", new Client(20000)));
            lst.Add(new PersonalData("Гарифуллин Ильсаф Ильнарович", "Казань", new Client(25000)));
            lst.Add(new PersonalData("Хлыбов Владислав Владимирович", "Казань", new Client(35000)));
            lst.Add(new PersonalData("Баннов Филипп Германович", "Казань", new Employee(20000)));
            lst.Add(new PersonalData("Яруллин Талгат Рамильевич", "Казань", new Employee(55000)));
        }
        static void Main(string[] args)
        {
            StartProgram();
            Operations.Dobavleniye(lst);
            Operations.ShowList(lst);
            Account Account1 = new Client(12000);
            Account Account2 = new Employee(9000);
            Console.WriteLine(Account1.Balance + " р. Сумма первого аккаунта");//  Вывод первого баланса на консоль
            Console.WriteLine(Account2.Balance + " р. Сумма второго аккаунта");//  Вывод первого баланса на консоль
            Operations.Widthdraw(Account1, 600); //Сумма снятия со счёта первого аккаунта 
            Operations.Deposit(Account1, 1500); //Внесение депозита размером ... на счёт первого аккаунта
            Operations.Transaction(Account1, Account2, 5000);//Проводим транзакцию через 1 и 2 аккаунт,
                                                             //забираем 5к у первого ака и добавляем на сумму второго,после идет дейсвие снятия со счёта денег 1 аккаунта(widthdraw)

            Console.WriteLine("Введите сумму кредита");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Сумма кредита = {Operations.Credit(Account1, Account1.CreditStavka, sum)}\nБаланс = {Account1.Balance}");

        }

    }
}
