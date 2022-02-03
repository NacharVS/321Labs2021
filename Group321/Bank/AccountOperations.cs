using System;
using System.Collections.Generic;

namespace Bank
{
    public class AccountOperations : IAccountOperations
    {
        private List<Account> lst;
        public List<Account> Lst { get => lst; set => lst = value; }

        public void StartProgram()
        {
            lst = new List<Account>();
            lst.Add(new Client(20000, new PersonalData("Иванов Иван Иванович", "Казань")));
            lst.Add(new Employee(50000, new PersonalData("Петров Петр Петрович", "Казань")));
            lst.Add(new Client(30000, new PersonalData("Иванов Петр Петрович", "Казань")));
            lst.Add(new Employee(70000, new PersonalData("Петров Иван Иванович", "Казань")));
            lst.Add(new Client(40000, new PersonalData("Иванов Василий петрович", "Казань")));
        }

        public void RemoveList(Account acc, int a) // 
        {
            try
            {
                if (acc != lst[a])
                    lst.RemoveAt(a);
                else
                    throw new Exception("Текущий аккаунт нельзя удалить");
                Console.WriteLine("Удаление аккаунта прошло удачно");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Удаление аккаунта завершилось неудачно, введите корректные данные\n{ex.Message}");
            }
        }

        public void AddList()
        {
            Console.WriteLine("Введите ФИО");
            string FIO = Console.ReadLine();
            Console.WriteLine("Введите адрес");
            string addres = Console.ReadLine();
            Console.WriteLine("Введите должность?\n1) Client\n2) Employee");
            switch (Console.ReadLine())
            {
                case "1":
                    lst.Add(new Client(20000, new PersonalData(FIO, addres)));
                    break;
                case "2":
                    lst.Add(new Employee(20000, new PersonalData(FIO, addres)));
                    break;

                default:
                    Console.WriteLine("Введите корректные данные");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }

        public void Showlst()
        {
            int i = 1;
            foreach (var item in lst)
            {
                Console.WriteLine($"{i}) {item.PD.FIO}, {item.PD.Addres}, {item.Balance}, {item.ToString().Substring(9)}");
                i++;
            }
        }

        public void Reduct()
        {
            Console.WriteLine("Введите индекс редактируемого аккаунта");
            int a = Convert.ToInt32(Console.ReadLine());

            var acc = lst[a];
            var str = lst[a].PD;
            Console.WriteLine("Введите ФИО редактируемого аккаунта");
            str.FIO = Console.ReadLine();
            lst[a].PD = str;

            Console.WriteLine("Введите адрес редактируемого аккаунта");
            str.Addres = Console.ReadLine();
            lst[a].PD = str;

            if (acc.ToString().Substring(9) == "Client")
            {
                Console.WriteLine("Сделать клиента сотрудником банка?\n1)Да\n2)Нет");
                switch (Console.ReadLine())
                {
                    case "1":
                        double balance = acc.Balance;
                        acc = new Employee(balance, str, acc.Credit, acc.Vklad);
                        lst[a] = acc;
                        break;
                    case "2":
                        Console.WriteLine("Редактирование завершено успешно");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Уволить сотрудника банка?\n1)Да\n2)Нет");
                switch (Console.ReadLine())
                {
                    case "1":
                        double balance = acc.Balance;
                        acc = new Client(balance, str, acc.Credit, acc.Vklad);
                        lst[a] = acc;
                        break;
                    case "2":
                        Console.WriteLine("Редактирование завершено успешно");
                        break;
                }
            }
        }

        public int ChooseAcc()
        {
            Showlst();
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                number--;
                Account account = lst[number];
                return number;
            }
            catch
            {
                Console.WriteLine("Введите номер из списка!");
                Environment.Exit(0);
            }

            return 0;
        }
    }
}
