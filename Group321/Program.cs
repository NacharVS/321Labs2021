using System;
using System.Collections.Generic;

namespace Group321
{
    class Program
    {
        List<PersonalData> lst = new List<PersonalData>();

        void Main(string[] args)
        {
            double creditSum;
            Account acc = null;
            Account acc1 = new Account();

            Console.WriteLine("Who is you?\n1) Client\n2) Employee");
            switch (Console.ReadLine())
            {
                case "1":
                    acc = new Client();
                    break;
                case "2":
                    acc = new Employee();
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

        void Menu()
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

        void StartProgram()
        {
            lst = new List<PersonalData>();
            lst.Add(new PersonalData("Иванов Иван Иванович", "Казань", new Client(20000)));
            lst.Add(new PersonalData("Петров Петр Петрович", "Казань", new Employee(50000)));
            lst.Add(new PersonalData("Иванов Петр Петрович", "Казань", new Client(30000)));
            lst.Add(new PersonalData("Петров Иван Иванович", "Казань", new Employee(70000)));
            lst.Add(new PersonalData("Иванов Василий петрович", "Казань", new Client(40000)));
        }

        void RemoveList()
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

        void AddList()
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

        void Reduct()
        {
            Console.WriteLine("Введите индекс редактируемого аккаунта");
            int a = Convert.ToInt32(Console.ReadLine());

            var str = lst[a];
            Console.WriteLine("Введите ФИО редактируемого объекта");
            str.FIO = Console.ReadLine();
            lst[a] = str;

            Console.WriteLine("Введите адрес редактируемого объекта");
            str.addres = Console.ReadLine();
            lst[a] = str;
        }
    }
}
