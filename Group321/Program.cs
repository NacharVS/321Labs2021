using System;
using BAClasses;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
             while (true)
             {
                /*Account yourRate = new Account();
                yourRate.Balance = double.Parse(Console.ReadLine());
                Operation.ShowBalance(yourRate);

                Console.WriteLine("------Find out your rate-----------");
                Console.WriteLine("Your amount: ");
                double urBalance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Count of months: ");
                int months = int.Parse(Console.ReadLine());
                Operation.InterestRate(urBalance, months, yourRate);
                Console.WriteLine();*/
               
                Account yourCreditPay = new Account();
                Console.WriteLine("Your amount of credit: ");
                yourCreditPay.CreditBalance = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Your credit rate: ");
                Console.WriteLine("Your count of months: ");
                int monthsOfCred = Convert.ToInt32(Console.ReadLine());
                Operation.Credit(yourCreditPay, monthsOfCred);
                

                
            }
        }
    }
}
