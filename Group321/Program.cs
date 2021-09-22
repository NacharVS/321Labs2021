using System;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            double creditSum;
            Account acc = null;
            Account acc1 = new Account();

            Console.WriteLine("Who is you?\n1) Client\n2) Employee");
            switch (Console.ReadLine())
            {
                case "1":
                    acc = new Client();
                    acc.ProcentStavkaCredit = 7;
                    acc.ProcentStavkaVklad = 3;
                    break;
                case "2":
                    acc = new Employee();
                    acc.ProcentStavkaCredit = 4;
                    acc.ProcentStavkaVklad = 7;
                    break;

                default:
                    Console.WriteLine("Enter correct data");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }

            while (true)
            {
                Menu();
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Balance acc:  ");
                        Operations.ShowBalance(acc);
                        Console.Write("Balance acc1:  ");
                        Operations.ShowBalance(acc1);
                        break;
                    case "2":
                        Console.WriteLine("Enter deposit sum");
                        double sum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"баланс пополнен на {Operations.Deposit(acc, sum)} рублей");
                        break;
                    case "3":
                        Console.WriteLine("Enter transaction sum");
                        double transactionSum = Convert.ToDouble(Console.ReadLine());
                        Operations.Transaction(acc, acc1, transactionSum);
                        break;
                    case "4":
                        Console.WriteLine("Enter credit sum");
                        creditSum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter TimeSpan in mounth");
                        Operations.GetCredit(acc, Convert.ToInt32(Console.ReadLine()), creditSum);
                        break;
                    case "5":
                        Console.WriteLine("Enter transaction sum");
                        double widtrawSum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"С баланса снято {Operations.Widtraw(acc, widtrawSum)} рублей\nОстаток ");
                        Operations.ShowBalance(acc);
                        break;
                    case "6":
                        Console.WriteLine("Enter vklad sum");
                        double vkladSum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter TimeSpan in mounth");
                        int mounthCount = Convert.ToInt32(Console.ReadLine());
                        Operations.Vklad(acc, vkladSum, mounthCount);
                        break;
                    case "7":
                        Console.WriteLine("Enter credit repayment sum");
                        double repaymentSum = Convert.ToDouble(Console.ReadLine());
                        Operations.PayCredit(acc, repaymentSum);
                        break;
                    case "8":
                        // выход из приложения 
                        Environment.Exit(0);
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
            Console.WriteLine("7: Оплатить кредит");
            Console.WriteLine("8: Выйти из приложения");
        }
    }
}
