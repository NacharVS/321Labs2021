using System;

namespace Group321
{
    class Program
    {


        static void Main(string[] args)
        {
            AccountOperations.StartProgram();
            double creditSum;
            int number = AccountOperations.ChooseAcc();

            while (true)
            {
                Menu();
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write($"Balance {AccountOperations.Lst[number].PD.FIO}, {AccountOperations.Lst[number].ToString().Substring(9)}:  ");
                        Operations.ShowBalance(AccountOperations.Lst[number]);
                        break;
                    case "2":
                        Console.WriteLine("Enter deposit sum");
                        double sum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"баланс пополнен на {Operations.Deposit(AccountOperations.Lst[number], sum)} рублей");
                        break;
                    case "3":
                        Console.WriteLine("Enter transaction sum");
                        double transactionSum = Convert.ToDouble(Console.ReadLine());
                        Operations.Transaction(AccountOperations.Lst[number], AccountOperations.Lst[AccountOperations.ChooseAcc()], transactionSum);
                        break;
                    case "4":
                        Console.WriteLine("Enter credit sum");
                        creditSum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter TimeSpan in mounth");
                        Operations.GetCredit(AccountOperations.Lst[number], Convert.ToInt32(Console.ReadLine()), creditSum);
                        break;
                    case "5":
                        Console.WriteLine("Enter transaction sum");
                        double widtrawSum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"С баланса снято {Operations.Widtraw(AccountOperations.Lst[number], widtrawSum)} рублей\nОстаток {AccountOperations.Lst[number].Balance} рублей, {AccountOperations.Lst[number].BalanceDollar}$");
                        Operations.ShowBalance(AccountOperations.Lst[number]);
                        break;
                    case "6":
                        Console.WriteLine("Enter vklad sum");
                        double vkladSum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter TimeSpan in mounth");
                        int mounthCount = Convert.ToInt32(Console.ReadLine());
                        Operations.Vklad(AccountOperations.Lst[number], vkladSum, mounthCount);
                        break;
                    case "7":
                        Console.WriteLine("Enter credit repayment sum");
                        double repaymentSum = Convert.ToDouble(Console.ReadLine());
                        Operations.PayCredit(AccountOperations.Lst[number], repaymentSum);
                        break;
                    case "8":
                        AccountOperations.AddList();
                        break;
                    case "9":
                        AccountOperations.RemoveList(AccountOperations.Lst[number]);
                        break;
                    case "10":
                        AccountOperations.Showlst();
                        break;
                    case "11":
                        AccountOperations.Reduct();
                        break;
                    case "12":
                        number = AccountOperations.ChooseAcc();
                        break;
                    case "13":
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
            Console.WriteLine("\n1: Посмотреть баланс");
            Console.WriteLine("2: Пополнить баланс");
            Console.WriteLine("3: Перевести другому клиенту");
            Console.WriteLine("4: Взять кредит");
            Console.WriteLine("5: Снять деньги");
            Console.WriteLine("6: Открыть вклад");
            Console.WriteLine("7: Оплатить кредит");
            Console.WriteLine("8: Добавить аккаунт");
            Console.WriteLine("9: Удалить аккаунт");
            Console.WriteLine("10: Просмотреть все аккаунты");
            Console.WriteLine("11: Редактировать аккаунт");
            Console.WriteLine("12: Сменить аккаунт");
            Console.WriteLine("13: Выйти из приложения");
        }
    }
}