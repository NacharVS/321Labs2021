using System;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            Account acc1 = new Account();
            var menuNumber = "0";
            double creditSum;

            while (true)
            {
                Menu();
                menuNumber = Console.ReadLine();
                switch (menuNumber)
                {
                    case "1":
                        Console.Write("Balance acc:  ");
                        Operations.ShowBalance(acc);
                        Console.Write("Balance acc1:  ");
                        Operations.ShowBalance(acc1);
                        break;
                    case "2":
                        Console.WriteLine($"баланс пополнен на {Operations.Deposit(acc)} рублей");
                        break;
                    case "3":
                        Operations.Transaction(acc, acc1);
                        break;
                    case "4":
                        Console.WriteLine("Enter credit sum");
                        creditSum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter TimeSpan in mounth");
                        Operations.GetCredit(acc, Convert.ToInt32(Console.ReadLine()), creditSum);
                        break;
                    case "5":
                        Console.WriteLine($"С баланса снято {Operations.Widtraw(acc)} рублей\nОстаток ");
                        Operations.ShowBalance(acc);
                        break;
                    case "6":
                        Operations.Vklad(acc);
                        break;
                    case "7":
                        // выход из приложения 
                        break;

                    default:
                        Console.WriteLine("Enter correct data");
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("\n\n\n1: Посмотреть баланс");
            Console.WriteLine("2: Пополнить баланс");
            Console.WriteLine("3: Перевести другому клиенту");
            Console.WriteLine("4: Взять кредит");
            Console.WriteLine("5: Снять деньги");
            Console.WriteLine("6: Открыть вклад");
            Console.WriteLine("7: Выйти из приложения");
        }
    }
}
