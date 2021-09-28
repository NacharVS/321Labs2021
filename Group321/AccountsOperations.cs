using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class AccountsOperations
    {
        private static List<PersonalData> lst;
        public static List<PersonalData> list { get => lst; private set => lst = value; }
        public static void StartProgram()
        {
            list = new List<PersonalData>();
            list.Add(new PersonalData("Хлыбов Владислав Владимирович", "Казань", new Employee(100000)));
            list.Add(new PersonalData("Габдрахманов Айрат Ильдусович", "Можга", new Klient(40000)));
            list.Add(new PersonalData("Баязитов Руслан Айратович", "Казань", new Klient(10000)));
            list.Add(new PersonalData("Гарифуллин Ильсаф Ильнарович", "Казань", new Employee(50000)));
            list.Add(new PersonalData("Краснов Александр Григорьевич", "Казань", new Klient(20000)));
        }

        public static void ShowKlientlist()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Clientlist is empty");
            }
            else
            {
                foreach (var item in list)
                {
                    if (item.acc.ToString() == "Group321.Employee")
                    {
                        Console.WriteLine($"{item.fio} , {item.adress}, {item.acc.Balance}, Сотрудник");
                    }
                    else if (item.acc.ToString() == "Group321.Klient")
                    {
                        Console.WriteLine($"{item.fio} , {item.adress}, {item.acc.Balance}, Клиент");
                    }

                }
            }
        }

        public static void RemoveKlient()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Clientlist is empty");
            }
            else
            {
                Console.WriteLine("Enter the full name of klient");
                string rem = Console.ReadLine();
                int cnt = 0;
                foreach (var item in list)
                {
                    if (item.fio == rem)
                    {
                        list.Remove(item);
                        Console.WriteLine("Remove complete");
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0) { Console.WriteLine("There is no such client"); }
            }
        }

        public static void AddKlient()
        {
            Console.WriteLine("Enter the full name of klient");
            string fulln = Console.ReadLine();
            Console.WriteLine("Enter the adress of klient");
            string adres = Console.ReadLine();
            Console.WriteLine("Enter the balance of klient");
            double bal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select a position");
            Console.WriteLine("\n1.Klient");
            Console.WriteLine("2.Employee");
            int position = Convert.ToInt32(Console.ReadLine());
            if (position == 1) { list.Add(new PersonalData(fulln, adres, new Klient(bal))); }
            else if (position == 2) { list.Add(new PersonalData(fulln, adres, new Employee(bal))); }
            Console.WriteLine("Completed");
        }

        public static void EditKlient()
        {
            Console.WriteLine("Enter the full name of klient");
            string rem = Console.ReadLine();
            int cnt = 0;
            int cnt2 = 0;
            foreach (var item in list)
            {
                if (item.fio == rem)
                {
                    string fulln = "";
                    string adres = "";
                    double bal = 0;
                    Console.WriteLine("Change the full name? 1.Yes / 2.No");
                    int chan1 = Convert.ToInt32(Console.ReadLine());
                    if (chan1 == 1)
                    {
                        Console.WriteLine("Enter the new full name of klient");
                        fulln = Console.ReadLine();
                    }
                    else if (chan1 == 2) { fulln = item.fio; }
                    Console.WriteLine("Change the adress? 1.Yes / 2.No");
                    int chan2 = Convert.ToInt32(Console.ReadLine());
                    if (chan2 == 1)
                    {
                        Console.WriteLine("Enter the new adress of klient");
                        adres = Console.ReadLine();
                    }
                    else if (chan2 == 2) { adres = item.adress; }
                    Console.WriteLine("Change the balance? 1.Yes / 2.No");
                    int chan3 = Convert.ToInt32(Console.ReadLine());
                    if (chan3 == 1)
                    {
                        Console.WriteLine("Enter the new balance of klient");
                        bal = Convert.ToDouble(Console.ReadLine());
                    }
                    else if (chan3 == 2) { bal = item.acc.Balance; }
                    Console.WriteLine("Change the position? 1.Yes / 2.No");
                    int chan4 = Convert.ToInt32(Console.ReadLine());
                    if (chan4 == 1)
                    {
                        Console.WriteLine("Select a new position");
                        Console.WriteLine("\n1.Klient");
                        Console.WriteLine("2.Employee");
                        int position = Convert.ToInt32(Console.ReadLine());
                        if (position == 1) { list[cnt2] = new PersonalData(fulln, adres, new Klient(bal)); }
                        else if (position == 2) { list[cnt2] = new PersonalData(fulln, adres, new Employee(bal)); }
                    }
                    else if (chan4 == 2)
                    {
                        if (item.acc.ToString() == "Group321.Employee")
                        {
                            list[cnt2] = new PersonalData(fulln, adres, new Employee(bal));
                        }
                        else if (item.acc.ToString() == "Group321.Klient")
                        {
                            list[cnt2] = new PersonalData(fulln, adres, new Klient(bal));
                        }
                    }
                    Console.WriteLine("Completed");
                    cnt++;
                    break;
                }
                else { cnt2++; }
            }
            if (cnt == 0) { Console.WriteLine("There is no such client"); }
        }
    }
}
