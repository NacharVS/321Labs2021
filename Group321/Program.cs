using System;

namespace Group321
{
    class Program
    {
        private static double creditSum;
        private static int number;
        private static AccountOperations accountOperations = new AccountOperations();
        static void Main(string[] args)
        {
            accountOperations.StartProgram();
            Console.WriteLine("Кто вы? Введите номер из списка");
            number = accountOperations.ChooseAcc();

            while (true)
            {
                accountOperations.Lst[number].Menu();
                if (accountOperations.Lst[number].ToString().Substring(9) == "Employee")
                    menuEmployee();
                else
                    menuClient();
            }
        }

        static void menuClient()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write($"Balance {accountOperations.Lst[number].PD.FIO}, {accountOperations.Lst[number].ToString().Substring(9)}:  ");
                    Operations.ShowBalance(accountOperations.Lst[number]);
                    break;
                case "2":
                    Console.WriteLine("Enter deposit sum");
                    double sum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"баланс пополнен на {Operations.Deposit(accountOperations.Lst[number], sum)} рублей");
                    break;
                case "3":
                    Console.WriteLine("Enter transaction sum");
                    double transactionSum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Кому перевести? Введите номер из списка");
                    int number1 = accountOperations.ChooseAcc();
                    Operations.Transaction(accountOperations.Lst[number], accountOperations.Lst[number1], transactionSum);
                    break;
                case "4":
                    Console.WriteLine("Enter credit sum");
                    creditSum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter TimeSpan in mounth");
                    Operations.GetCredit(accountOperations.Lst[number], Convert.ToInt32(Console.ReadLine()), creditSum);
                    break;
                case "5":
                    Console.WriteLine("Enter widtraw sum");
                    double widtrawSum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"С баланса снято {Operations.Widtraw(accountOperations.Lst[number], widtrawSum)} рублей\nОстаток {accountOperations.Lst[number].Balance} рублей, {accountOperations.Lst[number].BalanceDollar}$");
                    Operations.ShowBalance(accountOperations.Lst[number]);
                    break;
                case "6":
                    Console.WriteLine("Enter vklad sum");
                    double vkladSum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter TimeSpan in mounth");
                    int mounthCount = Convert.ToInt32(Console.ReadLine());
                    Operations.Vklad(accountOperations.Lst[number], vkladSum, mounthCount);
                    break;
                case "7":
                    Console.WriteLine("Enter credit repayment sum");
                    double repaymentSum = Convert.ToDouble(Console.ReadLine());
                    Operations.PayCredit(accountOperations.Lst[number], repaymentSum);
                    break;
                case "8":
                    Console.WriteLine("Какой аккаунт выбрать? Введите номер из списка");
                    number = accountOperations.ChooseAcc();
                    break;
                case "9":
                    // выход из приложения 
                    Environment.Exit(0);
                    break;


                default:
                    Console.WriteLine("Enter correct data");
                    break;
            }
        }

        static void menuEmployee()
        {
            switch (Console.ReadLine())
            {
                case "1":

                    Console.Write($"Balance {accountOperations.Lst[number].PD.FIO}, {accountOperations.Lst[number].ToString().Substring(9)}:  ");
                    Operations.ShowBalance(accountOperations.Lst[number]);
                    break;
                case "2":
                    Console.WriteLine("Enter deposit sum");
                    double sum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"баланс пополнен на {Operations.Deposit(accountOperations.Lst[number], sum)} рублей");
                    break;
                case "3":
                    Console.WriteLine("Enter transaction sum");
                    double transactionSum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Кому перевести? Введите номер из списка");
                    int number1 = accountOperations.ChooseAcc();
                    Operations.Transaction(accountOperations.Lst[number], accountOperations.Lst[number1], transactionSum);
                    break;
                case "4":
                    Console.WriteLine("Enter credit sum");
                    creditSum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter TimeSpan in mounth");
                    Operations.GetCredit(accountOperations.Lst[number], Convert.ToInt32(Console.ReadLine()), creditSum);
                    break;
                case "5":
                    Console.WriteLine("Enter transaction sum");
                    double widtrawSum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"С баланса снято {Operations.Widtraw(accountOperations.Lst[number], widtrawSum)} рублей\nОстаток {accountOperations.Lst[number].Balance} рублей, {accountOperations.Lst[number].BalanceDollar}$");
                    Operations.ShowBalance(accountOperations.Lst[number]);
                    break;
                case "6":
                    Console.WriteLine("Enter vklad sum");
                    double vkladSum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter TimeSpan in mounth");
                    int mounthCount = Convert.ToInt32(Console.ReadLine());
                    Operations.Vklad(accountOperations.Lst[number], vkladSum, mounthCount);
                    break;
                case "7":
                    Console.WriteLine("Enter credit repayment sum");
                    double repaymentSum = Convert.ToDouble(Console.ReadLine());
                    Operations.PayCredit(accountOperations.Lst[number], repaymentSum);
                    break;
                case "8":
                    accountOperations.AddList();
                    break;
                case "9":
                    Console.WriteLine("Введите индекс удаляемого аккаунта");
                    int a = Convert.ToInt32(Console.ReadLine());
                    accountOperations.RemoveList(accountOperations.Lst[number], a);
                    if (number > a)
                        number--;
                    break;
                case "10":
                    accountOperations.Showlst();
                    break;
                case "11":
                    accountOperations.Reduct();
                    break;
                case "12":
                    Console.WriteLine("Какой аккаунт выбрать? Введите номер из списка");
                    number = accountOperations.ChooseAcc();
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
}