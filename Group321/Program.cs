using System;
using System.Collections.Generic;
using BankCore;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Start();

            List<Employee> employeList = new List<Employee>()
            {
                new Employee("Chuck", "Norris", 21, 800800, "Bodyguard"),
                new Employee("Stephen", "Hawking", 76, 800800, "Manager"),
                new Employee("Danil", "Karpov", 18, 800800, "Director")
            };

            List<Client> clientList = new List<Client>();

            while (true)
            {
                Console.WriteLine($"\tPress '1' to make a new profile\n\tPress '2' to take info about us\n\tPress '3' to exit");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        Console.WriteLine($"\tWrite name, surname, age and phone number");
                        Console.WriteLine($"\tExample: Ivan;Ivanov;18;500500");

                        try
                        { 
                            clientList.Add(Adder());
                            Console.WriteLine($"\tWelcome {clientList[clientList.Count-1]}!");
                        }
                        catch
                        {
                            Console.WriteLine($"\tIncorrect input!");
                        }
                        goto case "1.1";
                    case "1.1":
                        Console.WriteLine($"\tPress '1' edit profile\n\tPress '2' del profile\n\tPress '3' to go back in main menu");
                        var answer = Convert.ToInt32(Console.ReadLine());
                        if (answer == 1)
                        {
                            goto case "1.11";
                        }
                        else if(answer == 2)
                        {
                            goto case "1.12";
                        }
                        else if (answer == 3)
                        {
                            break;
                        }

                        break;
                    case "1.11":
                        Console.WriteLine($"\tPress '1' to edit name\n\tPress '2' to edit surname\n\tPress '3' to edit age");
                        var answer2 = Convert.ToInt32(Console.ReadLine());
                        if (answer2 == 1)
                        {
                            Console.WriteLine("Write new name!");
                            clientList[clientList.Count - 1].Name = Console.ReadLine();
                            break;
                        }
                        else if(answer2 == 2)
                        {
                            Console.WriteLine("Write new surname!");
                            clientList[clientList.Count - 1].Surname = Console.ReadLine();
                            break;
                        }
                        else if (answer2 == 3)
                        {
                            Console.WriteLine("Write new age!");
                            clientList[clientList.Count - 1].Age = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        break;

                    case "1.12":
                        if (clientList != null)
                        {
                            clientList.RemoveAt(clientList.Count - 1);
                            Console.WriteLine("Bye!");
                        }
                        break;

                    case "2":
                        Console.WriteLine($"\tOur personal:");

                        foreach(var psnl in employeList)
                        {
                            psnl.PersonalInfo();
                        }

                        Console.WriteLine($"\tOur client:");

                        if(clientList.Count >= 1)
                        {
                            foreach (var clnt in clientList)
                            {
                                clnt.PersonalInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Now we have 0 client. But you can be first!");
                        }
                        break;

                    case "3":
                        return;
                }
            }

        }

        public static Client Adder()
        {
            string str = Console.ReadLine();
            string[] subs = str.Split(';');

            Client pd = new Client(subs[0], subs[1], Convert.ToInt32(subs[2]), Convert.ToInt32(subs[3]));
            return pd;
        }
    }
}
