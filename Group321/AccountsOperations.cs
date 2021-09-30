using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class AccountsOperations
    {
        private static List<Account> lst;
        public static List<Account> list { get => lst; private set => lst = value; }
        public static void StartProgram()
        {
            list = new List<Account>();
            list.Add(new Employee(100000, new PersonalData("Хлыбов Владислав Владимирович", "Казань")));
            list.Add(new Klient(40000, new PersonalData("Габдрахманов Айрат Ильдусович", "Можга")));
            list.Add(new Klient(10000, new PersonalData("Баязитов Руслан Айратович", "Казань")));
            list.Add(new Employee(50000, new PersonalData("Гарифуллин Ильсаф Ильнарович", "Казань")));
            list.Add(new Klient(20000, new PersonalData("Краснов Александр Григорьевич", "Казань")));
        }

        public static void ShowKlientlist()
        {
            int cnt = 1;
            if (list.Count == 0)
            {
                Console.WriteLine("Clientlist is empty");
            }
            else
            {
                foreach (var item in list)
                {
                    if (item.ToString() == "Group321.Employee")
                    {
                        Console.WriteLine($"{cnt}.{item.pd.FIO} , {item.pd.Adress}, {item.Balance}, Сотрудник");
                    }
                    else if (item.ToString() == "Group321.Klient")
                    {
                        Console.WriteLine($"{cnt}.{item.pd.FIO} , {item.pd.Adress}, {item.Balance}, Клиент");
                    }
                    cnt++;
                }
            }
        }

        public static void RemoveKlient()
        {
            try
            {
                int ch = ChooseAcc();
                list.RemoveAt(ch);
                Console.WriteLine("Remove comlete");
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public static void AddKlient()
        {
            Console.WriteLine("Enter the full name of klient");
            string fulln = Console.ReadLine();
            Console.WriteLine("Enter the adress of klient");
            string adres = Console.ReadLine();
            double bal = 0;
            Console.WriteLine("Select a position");
            Console.WriteLine("\n1.Klient");
            Console.WriteLine("2.Employee");
            int position = Convert.ToInt32(Console.ReadLine());
            if (position == 1) { list.Add(new Klient(bal, new PersonalData(fulln, adres))); }
            else if (position == 2) { list.Add(new Employee(bal, new PersonalData(fulln, adres))); }
            Console.WriteLine("Completed");
        }

        public static int ChooseAcc()
        {
            Console.WriteLine("Choose account");
            ShowKlientlist();
            int ac = Convert.ToInt32(Console.ReadLine())-1;
            while (ac > list.Count || ac < 0)
            {
                Console.WriteLine("Incorrect.Try again");
                ac = Convert.ToInt32(Console.ReadLine())-1;
            }
            return ac;
        }

        public static int ShowData(int Num)
        {
            Console.WriteLine($"Full name: {list[Num].pd.FIO}");
            Console.WriteLine($"Adress: {list[Num].pd.Adress}");
            Console.WriteLine($"Balance: {list[Num].Balance}");
            Console.WriteLine($"Balance: {list[Num].Balance}");
            if (list[Num].Credit > 0) { Console.WriteLine($"You have credit.Your debt is {list[Num].Credit}"); }
            if (list[Num].Vklad > 0) { Console.WriteLine($"You have invested {list[Num].Vklad} for {list[Num].timeVklad} years "); }
            return 0;
        }

        public static int EditKlient(int Num)
        {
            try
            {
                string fulln = "";
                string adres = "";
                Console.WriteLine("Change the full name? 1.Yes / 2.No");
                int chan1 = Convert.ToInt32(Console.ReadLine());
                if (chan1 == 1)
                {
                    Console.WriteLine("Enter the new full name of klient");
                    fulln = Console.ReadLine();
                }
                else if (chan1 == 2) { fulln = list[Num].pd.FIO; }
                Console.WriteLine("Change the adress? 1.Yes / 2.No");
                int chan2 = Convert.ToInt32(Console.ReadLine());
                if (chan2 == 1)
                {
                    Console.WriteLine("Enter the new adress of klient");
                    adres = Console.ReadLine();
                }
                else if (chan2 == 2) { adres = list[Num].pd.Adress; }
                Console.WriteLine("Change the position? 1.Yes / 2.No");
                int chan4 = Convert.ToInt32(Console.ReadLine());
                if (chan4 == 1)
                {
                    Console.WriteLine("Select a new position");
                    Console.WriteLine("\n1.Klient");
                    Console.WriteLine("2.Employee");
                    int position = Convert.ToInt32(Console.ReadLine());
                    if (position == 1) { list[Num] = new Klient(list[Num].Balance, new PersonalData(fulln, adres), list[Num].Credit, list[Num].Vklad, list[Num].timeVklad); }
                    else if (position == 2) { list[Num] = new Employee(list[Num].Balance, new PersonalData(fulln, adres), list[Num].Credit, list[Num].Vklad, list[Num].timeVklad); }
                }
                else if (chan4 == 2)
                {
                    if (list[Num].ToString() == "Group321.Employee")
                    {
                        list[Num] = new Employee(list[Num].Balance, new PersonalData(fulln, adres), list[Num].Credit, list[Num].Vklad, list[Num].timeVklad);
                    }
                    else if (list[Num].ToString() == "Group321.Klient")
                    {
                        list[Num] = new Klient(list[Num].Balance, new PersonalData(fulln, adres), list[Num].Credit, list[Num].Vklad, list[Num].timeVklad);
                    }
                }
                Console.WriteLine("Completed");
            }
            catch
            {
                Console.WriteLine("Error");
            }
            return 0;
        }
    }
}
