using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    static class AccountOperations
    {
        private static List<PersonalData> lst = new List<PersonalData>();
        public static List<PersonalData> Lst { get => lst; private set => lst = value; }

        public static void StartProgram()
        {
            lst = new List<PersonalData>();
            lst.Add(new PersonalData("Иванов Иван Иванович", "Казань", new Client(20000)));
            lst.Add(new PersonalData("Петров Петр Петрович", "Казань", new Employee(50000)));
            lst.Add(new PersonalData("Иванов Петр Петрович", "Казань", new Client(30000)));
            lst.Add(new PersonalData("Петров Иван Иванович", "Казань", new Employee(70000)));
            lst.Add(new PersonalData("Иванов Василий петрович", "Казань", new Client(40000)));
        }

        public static void RemoveList()
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

        public static void AddList()
        {
            Console.WriteLine("Введите ФИО");
            string FIO = Console.ReadLine();
            Console.WriteLine("Введите адрес");
            string addres = Console.ReadLine();
            Console.WriteLine("Введите должность?\n1) Client\n2) Employee");
            switch (Console.ReadLine())
            {
                case "1":
                    lst.Add(new PersonalData(FIO, addres, new Client(20000)));
                    break;
                case "2":
                    lst.Add(new PersonalData(FIO, addres, new Employee(20000)));
                    break;

                default:
                    Console.WriteLine("Введите корректные данные");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }

        public static void Showlst()
        {
            int i = 1;
            foreach (var item in lst)
            {
                Console.WriteLine($"{i}) {item.FIO}, {item.Addres}, {item.Acc.Balance}, {item.Acc.ToString().Substring(9)}");
                i++;
            }
        }

        public static void Reduct()
        {
            Console.WriteLine("Введите индекс редактируемого аккаунта");
            int a = Convert.ToInt32(Console.ReadLine());

            var str = lst[a];
            Console.WriteLine("Введите ФИО редактируемого аккаунта");
            str.FIO = Console.ReadLine();
            lst[a] = str;

            Console.WriteLine("Введите адрес редактируемого аккаунта");
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
                Console.WriteLine("Уволить сотрудника банка?\n1)Да\n2)Нет");
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

        public static int ChooseAcc()
        {
            Console.WriteLine("Кто вы? Введите номер из списка");
            Showlst();
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                number--;
                Account account = lst[number].Acc;
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
