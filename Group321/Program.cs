using System;
using System.Collections.Generic;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountsOperations.StartProgram();
            static int MenuStart()
            {
                Console.WriteLine("\n1.Sign in account");
                Console.WriteLine("2.Show klientlist");
                Console.WriteLine("3.Remove a klient from the list");
                Console.WriteLine("4.Add a klient to the list");
                int stp = Convert.ToInt32(Console.ReadLine());
                return stp;
            }
            while (true)
            {
                int st = MenuStart();
                if (st == 1)
                {
                    int num = AccountsOperations.ChooseAcc();
                    int choose;
                    while (true)
                    {
                        Console.WriteLine("\n1.Show account data");
                        Console.WriteLine("2.Transaction");
                        Console.WriteLine("3.Deposit");
                        Console.WriteLine("4.WidTraw");
                        Console.WriteLine("5.GetCredit");
                        Console.WriteLine("6.Invest");
                        Console.WriteLine("7.Payment credit");
                        Console.WriteLine("8.Edit klient data");
                        Console.WriteLine("9.Exit from account");
                        Console.WriteLine("\nChoose operation");
                        choose = Convert.ToInt32(Console.ReadLine());
                        if (choose == 1)
                        {
                            AccountsOperations.ShowData(num);
                        }
                        else if (choose == 2)
                        {
                            int trnum = AccountsOperations.ChooseAcc();
                            Console.WriteLine("Enter the transaction sum");
                            double sum = Convert.ToDouble(Console.ReadLine());
                            Operation.Transaction(AccountsOperations.list[num], AccountsOperations.list[trnum], sum);
                        }
                        else if (choose == 3)
                        {
                            Console.WriteLine("Enter the deposit sum");
                            double sum = Convert.ToDouble(Console.ReadLine());
                            Operation.Deposit(AccountsOperations.list[num], sum);
                        }
                        else if (choose == 4)
                        {
                            Console.WriteLine("Enter the widtraw sum");
                            double sum = Convert.ToDouble(Console.ReadLine());
                            Operation.Widtraw(AccountsOperations.list[num], sum);
                        }
                        else if (choose == 5)
                        {
                            if (AccountsOperations.list[num].Credit == 0)
                            {
                                Console.WriteLine("Enter credit sum");
                                double creditsum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter time of credit");
                                double time = Convert.ToDouble(Console.ReadLine());
                                Operation.GetCredit(AccountsOperations.list[num], time, creditsum);
                                Console.WriteLine($"Credit is approved.Your debt is {AccountsOperations.list[num].Credit}.The monthly payment will be {AccountsOperations.list[num].Credit / (time * 12)}");
                            }
                            else
                            {
                                Console.WriteLine($"Credit is not approved.Your debt is {AccountsOperations.list[num].Credit}");
                            }

                        }
                        else if (choose == 6)
                        {
                            if (AccountsOperations.list[num].Vklad == 0)
                            {
                                Console.WriteLine("Enter the invest sum");
                                double sum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter the invest time");
                                AccountsOperations.list[num].timeVklad = Convert.ToDouble(Console.ReadLine());
                                Operation.Invest(AccountsOperations.list[num], sum);
                            }
                            else
                            {
                                Console.WriteLine("Enter the invest sum");
                                double sum = Convert.ToDouble(Console.ReadLine());
                                Operation.Invest(AccountsOperations.list[num], sum);
                            }
                        }
                        else if (choose == 7)
                        {
                            if (AccountsOperations.list[num].Credit != 0)
                            {
                                Console.WriteLine("Enter the payment sum");
                                double sum = Convert.ToDouble(Console.ReadLine());
                                Operation.PaymentCredit(AccountsOperations.list[num], sum);
                            }
                            else
                            {
                                Console.WriteLine("You don't have credit");
                            }
                        }
                        else if (choose == 8)
                        {
                            AccountsOperations.EditKlient(num);
                        }
                        else if (choose == 9)
                        {
                            Console.Clear();
                            num = AccountsOperations.ChooseAcc();
                        }
                    }
                }
                else if (st == 2)
                {
                    AccountsOperations.ShowKlientlist();
                }
                else if (st == 3)
                {
                    AccountsOperations.RemoveKlient();
                }
                else if (st == 4)
                {
                    AccountsOperations.AddKlient();
                }
            }
        }
    }

}
