using System;
using System.Collections.Generic;

namespace Group321
{
    class Program
    {
        private static List<PersonalData> lst = new List<PersonalData>();
        private static Account account;
        private static int number;

        static void Main(string[] args)
        {
            StartProgram();
            double creditSum;
            Account acc1 = new Account();
            ChooseAcc();

            while (true)
            {
                Menu();
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write($"Balance {lst[number].FIO}, {lst[number].Acc.ToString().Substring(9)}:  ");
                        Operations.ShowBalance(lst[number].Acc);
                        Console.Write("Balance acc1:  ");
                        Operations.ShowBalance(acc1);
                        break;
                    case "2":
                        Console.WriteLine("Enter deposit sum");
                        double sum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"баланс пополнен на {Operations.Deposit(lst[number].Acc, sum)} рублей");
                        break;
                    case "3":
                        Console.WriteLine("Enter transaction sum");
                        double transactionSum = Convert.ToDouble(Console.ReadLine());
                        Operations.Transaction(lst[number].Acc, acc1, transactionSum);
                        break;
                    case "4":
                        Console.WriteLine("Enter credit sum");
                        creditSum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter TimeSpan in mounth");
                        Operations.GetCredit(lst[number].Acc, Convert.ToInt32(Console.ReadLine()), creditSum);
                        break;
                    case "5":
                        Console.WriteLine("Enter transaction sum");
                        double widtrawSum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"С баланса снято {Operations.Widtraw(lst[number].Acc, widtrawSum)} рублей\nОстаток {lst[number].Acc.Balance} рублей, {lst[number].Acc.BalanceDollar}$");
                        Operations.ShowBalance(lst[number].Acc);
                        break;
                    case "6":
                        Console.WriteLine("Enter vklad sum");
                        double vkladSum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter TimeSpan in mounth");
                        int mounthCount = Convert.ToInt32(Console.ReadLine());
                        Operations.Vklad(lst[number].Acc, vkladSum, mounthCount);
                        break;
                    case "7":
                        Console.WriteLine("Enter credit repayment sum");
                        double repaymentSum = Convert.ToDouble(Console.ReadLine());
                        Operations.PayCredit(lst[number].Acc, repaymentSum);
                        break;
                    case "8":
                        AddList();
                        break;
                    case "9":
                        RemoveList();
                        break;
                    case "10":
                        Showlst();
                        break;
                    case "11":
                        Reduct();
                        break;
                    case "12":
                        ChooseAcc();
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
            Console.WriteLine("\n\n\n1: Посмотреть баланс");
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
            Console.WriteLine("12: Изменить аккаунт");
            Console.WriteLine("13: Выйти из приложения");
        }

        static void StartProgram()
        {
            lst = new List<PersonalData>();
            lst.Add(new PersonalData("Иванов Иван Иванович", "Казань", new Client(20000)));
            lst.Add(new PersonalData("Петров Петр Петрович", "Казань", new Employee(50000)));
            lst.Add(new PersonalData("Иванов Петр Петрович", "Казань", new Client(30000)));
            lst.Add(new PersonalData("Петров Иван Иванович", "Казань", new Employee(70000)));
            lst.Add(new PersonalData("Иванов Василий петрович", "Казань", new Client(40000)));
        }

        static void RemoveList()
        {
            Console.WriteLine("Введите индекс удаляемого аккаунта");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                lst.RemoveAt(a);
                Console.WriteLine("Удаление аккаунта прошло удачно");
            }
            catch
            {
                Console.WriteLine("Удаление аккаунта завершилось неудачно, введите корректные данные");
            }
        }

        static void AddList()
        {
            Console.WriteLine("Введите ФИО");
            string FIO = Console.ReadLine();
            Console.WriteLine("Введите адрес");
            string addres = Console.ReadLine();
            Console.WriteLine("Who is you?\n1) Client\n2) Employee");
            switch (Console.ReadLine())
            {
                case "1":
                    lst.Add(new PersonalData(FIO, addres, new Client(20000)));
                    break;
                case "2":
                    lst.Add(new PersonalData(FIO, addres, new Employee(20000)));
                    break;

                default:
                    Console.WriteLine("Enter correct data");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }

        static void Showlst()
        {
            int i = 1;
            foreach (var item in lst)
            {
                Console.WriteLine($"{i}) {item.FIO}, {item.Addres}, {item.Acc.Balance}, {item.Acc.ToString().Substring(9)}");
                i++;
            }
        }

        static void Reduct()
        {
            Console.WriteLine("Введите индекс редактируемого аккаунта");
            int a = Convert.ToInt32(Console.ReadLine());

            var str = lst[a];
            Console.WriteLine("Введите ФИО редактируемого объекта");
            str.FIO = Console.ReadLine();
            lst[a] = str;

            Console.WriteLine("Введите адрес редактируемого объекта");
            str.Addres = Console.ReadLine();
            lst[a] = str;

            if (str.Acc.ToString().Substring(9) == "Client")
            {
                Console.WriteLine("Сделать клиента сотрудником банка?\n1)Да\n2)Нет");
                switch (Console.ReadLine())
                {
                    case "1":
                        double balance = str.Acc.Balance;
                        str.Acc = new Employee(balance);
                        lst[a] = str;
                        break;
                    case "2":
                        Console.WriteLine("Редактирование завершено успешно");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Уволить сотрудником банка?\n1)Да\n2)Нет");
                switch (Console.ReadLine())
                {
                    case "1":
                        double balance = str.Acc.Balance;
                        str.Acc = new Client(balance);
                        lst[a] = str;
                        break;
                    case "2":
                        Console.WriteLine("Редактирование завершено успешно");
                        break;
                }
            }
        }

        static void ChooseAcc()
        {
            Console.WriteLine("Кто вы? Введите номер из списка");
            Showlst();
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                number--;
                account = lst[number].Acc;
            }
            catch
            {
                Console.WriteLine("Введите номер из списка");
                Environment.Exit(0);
            }
        }
    }
}