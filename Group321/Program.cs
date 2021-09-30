using System;
using BAClasses;
using System.Collections.Generic;

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
               
                /*Account yourCreditPay = new Client();
                Console.WriteLine("Your amount of credit: ");
                yourCreditPay.CreditBalance = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Your credit rate: ");
                Console.WriteLine("Your count of months: ");
                int monthsOfCred = Convert.ToInt32(Console.ReadLine());
                Operation.CreditCalculator(yourCreditPay, monthsOfCred);

                Console.WriteLine();*/

                //Console.WriteLine("New Client");
                //Console.WriteLine("First name: ");
                //string fn = Console.ReadLine();
                //Console.WriteLine("Last name: ");
                //string ln = Console.ReadLine();
                //Console.WriteLine("Birth date: ");
                //Console.Write("Day - ");
                //string dd = Console.ReadLine();
                //Console.Write("Month - ");
                //string mm = Console.ReadLine();
                //Console.Write("Year - ");
                //string yy = Console.ReadLine();
                //Console.WriteLine("Telephone Number: ");
                //string num = Console.ReadLine();
                //Console.WriteLine();
                //PersonalData pd = new PersonalData(fn, ln, num, dd, mm, yy);
                //pd.GetPersonalData();

                //Console.WriteLine();
                List<Employee> employees = new List<Employee>()
                {
                    new Employee { Name = "Борис Алексеев", Age = 55 },
                    new Employee { Name = "Лариса Павлова", Age = 37 }
                };

                int button = int.Parse(Console.ReadLine());
                int index;

                switch(button)
                {
                    case 1: employees.Add(new Employee { Name = Console.ReadLine(), Age = Convert.ToInt32(Console.ReadLine()) });
                        break;
                    case 2: employees.RemoveAt(int.Parse(Console.ReadLine()));
                        break;
                    default: Console.WriteLine("error");
                        break;
                }

                foreach(Employee e in employees)
                {
                    Console.WriteLine($"Employee's Name - {e.Name}, Age - {e.Age}");
                }
            }
        }
    }
}
