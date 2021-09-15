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
               
                Account yourCreditPay = new Client();
                Console.WriteLine("Your amount of credit: ");
                yourCreditPay.CreditBalance = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Your credit rate: ");
                Console.WriteLine("Your count of months: ");
                int monthsOfCred = Convert.ToInt32(Console.ReadLine());
                Operation.CreditCalculator(yourCreditPay, monthsOfCred);

                Console.WriteLine();

                Console.WriteLine("New Client");
                Console.WriteLine("First name: ");
                string fn = Console.ReadLine();
                Console.WriteLine("Last name: ");
                string ln = Console.ReadLine();
                Console.WriteLine("Personal Account Number: ");
                string pan = Console.ReadLine();
                Console.WriteLine("Birth date: ");
                string bd = Console.ReadLine();
                Console.WriteLine("Telephone Number: ");
                string num = Console.ReadLine();
                Console.WriteLine();
                PersonalData pd = new PersonalData(fn, ln, num, bd, pan);
                pd.GetPersonalData();

                Console.WriteLine();                
            }
        }
    }
}
