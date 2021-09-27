using System;
using System.Collections.Generic;

namespace Group321
{
    class Program
    {
        public static List<PersonalData> list;
        static void StartProgram()
        {
            list = new List<PersonalData>();
            list.Add(new PersonalData("Хлыбов Владислав Владимирович", "Казань", new Employee(100000)));
            list.Add(new PersonalData("Габдрахманов Айрат Ильдусович", "Можга", new Klient(40000)));
            list.Add(new PersonalData("Баязитов Руслан Айратович", "Казань", new Klient(10000)));
            list.Add(new PersonalData("Гарифуллин Ильсаф Ильнарович", "Казань", new Employee(50000)));
            list.Add(new PersonalData("Краснов Александр Григорьевич", "Казань", new Klient(20000)));
        }
        static void Main(string[] args)
        {
            StartProgram();
            Account account = null;
            Console.WriteLine("\nChoose type of account");
            Console.WriteLine("\n1.Klient");
            Console.WriteLine("2.Employee");
            int typeacc = Convert.ToInt32(Console.ReadLine());
            if (typeacc == 1)
            {
                account = new Klient();
            }
            else if (typeacc == 2)
            {
                account = new Employee();
            }
            else
            {
                Console.WriteLine("Incorrect type of account");
            }
            Account account1 = new Account();
            account.Balance = 50000;
            int choose;
            while (true)
            {
                Console.WriteLine("\n1.Show balance");
                Console.WriteLine("2.Transaction");
                Console.WriteLine("3.Deposit");
                Console.WriteLine("4.WidTraw");
                Console.WriteLine("5.GetCredit");
                Console.WriteLine("6.Invest");
                Console.WriteLine("7.Payment credit");
                Console.WriteLine("8.Show klientlist");
                Console.WriteLine("9.Remove a klient from the list");
                Console.WriteLine("10.Add a klient to the list");
                Console.WriteLine("\nChoose operation");
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    Console.Write("Balance account = ");
                    Operation.ShowBalance(account);
                }
                else if (choose == 2)
                {
                    Console.WriteLine("Enter the transaction sum");
                    double sum = Convert.ToDouble(Console.ReadLine());
                    Operation.Transaction(account, account1, sum);
                    Console.Write("Balance accountGetter = ");
                    Operation.ShowBalance(account1);
                }
                else if (choose == 3)
                {
                    Console.WriteLine("Enter the deposit sum");
                    double sum = Convert.ToDouble(Console.ReadLine());
                    Operation.Deposit(account, sum);
                }
                else if (choose == 4)
                {
                    Console.WriteLine("Enter the widtraw sum");
                    double sum = Convert.ToDouble(Console.ReadLine());
                    Operation.Widtraw(account, sum);
                }
                else if (choose == 5)
                {
                    if (account.Credit == 0)
                    {
                        Console.WriteLine("Enter credit sum");
                        double creditsum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter time of credit");
                        double time = Convert.ToDouble(Console.ReadLine());
                        Operation.GetCredit(account, time, creditsum);
                        Console.WriteLine($"Credit is approved.Your debt is {account.Credit}.The monthly payment will be {account.Credit / (time * 12)}");
                    }
                    else
                    {
                        Console.WriteLine($"Credit is not approved.Your debt is {account.Credit}");
                    }

                }
                else if (choose == 6)
                {
                    if (account.Vklad == 0)
                    {
                        Console.WriteLine("Enter the invest sum");
                        double sum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the invest time");
                        account.timeVklad = Convert.ToDouble(Console.ReadLine());
                        Operation.Invest(account, sum);
                    }
                    else
                    {
                        Console.WriteLine("Enter the invest sum");
                        double sum = Convert.ToDouble(Console.ReadLine());
                        Operation.Invest(account, sum);
                    }
                }
                else if (choose == 7)
                {
                    if (account.Credit != 0)
                    {
                        Console.WriteLine("Enter the payment sum");
                        double sum = Convert.ToDouble(Console.ReadLine());
                        Operation.PaymentCredit(account, sum);
                    }
                    else
                    {
                        Console.WriteLine("You don't have credit");
                    }
                }
                else if (choose ==8 )
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("Clientlist is empty");
                    }
                    else
                    {
                        foreach (var item in list)
                        {
                            Console.WriteLine($"{item.fio} , {item.adress}, {item.acc.Balance} ");
                        }
                    }
                }
                else if (choose == 9)
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
                            if (cnt==0) { Console.WriteLine("There is no such client"); }
                    }
                }
                else if(choose==10)
                {
                    Console.WriteLine("Enter the full name of klient");
                    string fulln = Console.ReadLine();
                    Console.WriteLine("Enter the adress of klient");
                    string adres = Console.ReadLine();
                    Console.WriteLine("Enter the balance of klient");
                    double bal = Convert.ToDouble(Console.ReadLine());
                    list.Add(new PersonalData(fulln, adres, new Employee(bal)));
                    Console.WriteLine("Completed");
                }
            }
        }
    }

}
