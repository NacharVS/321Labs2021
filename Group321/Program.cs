using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static List<Account> accounts;
        static void Main(string[] args)
        {
            var acc = new Account(400, "qwerty", "Петр", "8904299428");
            var acc1 = new Account(500, "12345", "Иван", "8904299428");
            var acc2 = new Account(600, "asdfg", "Влад", "8904299428");
            var acc3 = new Account(700, "qqqq", "Саша", "8904299428");
            accounts = new List<Account>()
            {
            acc, acc1, acc2,acc3
            };

            Console.WriteLine("Введите ID пользователя");
            string id = Console.ReadLine();
            Console.WriteLine("Введите сумму перевода");
            int sum = Convert.ToInt32(Console.ReadLine());
            acc1.Transaction(id, sum);
        }

        public static Account GetAccount(string userId)
        {
            foreach (var item in accounts)
            {
                if (item.UserID == userId)
                    return item;
            }
            return null;
        }

        public static void Message(string mes)
        {
            Console.WriteLine(mes);
        }
    }

    public class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        public Account(int sum, string userID, string name, string phonenumber)
        {
            Sum = sum;
            UserID = userID;
            Name = name;
            PhonenNumber = phonenumber;
        }

        public int Sum { get; private set; }
        public string UserID { get; private set; }
        public string Name { get; private set; }
        public string PhonenNumber { get; private set; }

        public void Transaction(string userId, int sum)
        {
            Notify += Program.Message;
            var acc = Program.GetAccount(userId);
            if (Sum >= sum)
            {
                Sum -= sum;
                acc.Sum += sum;
                Notify?.Invoke($"со счета пользователя {Name} списано {sum} руб. Остаток средств {Sum}\nНа номер {acc.PhonenNumber} отправлено сообщение");
                // Console.WriteLine($"Было переведено {sum} рублей. Ваш баланс: {accSeller.Balance}");
                Console.WriteLine("Transaction completed");
            }
            else
            {
                Console.WriteLine("Transaction failed");
            }
            Notify -= Program.Message;
        }


    }
}