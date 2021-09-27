using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Personal
    {
        public string Sur { get; set; }
        public string Name { get; set; }
        public string YearDirth { get; set; }
        public int WorkExperience { get; set; }
        public string Post { get; set; }
    }
    class Client
    {
        public string Sur { get; set; }
        public string Name { get; set; }
        public string YearDirth { get; set; }
        public double BalansClient { get; set; }
    }
    class PersonalData
    {        
        public static void SotBanka()
        {
            List<Personal> sotrydnik = new List<Personal>();
            sotrydnik.Add(new Personal() { Sur = "Иванов", Name = "Иван", YearDirth = "01.09.1987", WorkExperience = 15, Post = "Администратор" });
            sotrydnik.Add(new Personal() { Sur = "Куринов", Name = "Валентин", YearDirth = "04.10.1991", WorkExperience = 9, Post = "Охранник" });
            sotrydnik.Add(new Personal() { Sur = "Арбузова", Name = "Екатерина", YearDirth = "16.12.2000", WorkExperience = 1, Post = "Операционист" });
            sotrydnik.Add(new Personal() { Sur = "Утюгова", Name = "Севара", YearDirth = "18.02.1990", WorkExperience = 7, Post = "Кредитный эксперт" });
            sotrydnik.Add(new Personal() { Sur = "Морозов", Name = "Виктор", YearDirth = "01.01.1999", WorkExperience = 3, Post = "Бухгалтер" });
            Console.WriteLine();
            foreach (var item in sotrydnik)
            {
                Console.WriteLine($"Сотрудник:{item.Sur} {item.Name} Дата рождения:{item.YearDirth}  Стаж работы:{item.WorkExperience} Должность:{item.Post}");            
            }
        }
        

        public static void ClientBanka()
        {
            List<Client> client = new List<Client>();
            client.Add(new Client() { Sur = "Павлов", Name = "Сергей", YearDirth = "01.07.1956", BalansClient = 30000.97 });
            client.Add(new Client() { Sur = "Игорев", Name = "Алесандр", YearDirth = "13.06.1967", BalansClient = 19876.09 });
            client.Add(new Client() { Sur = "Выхина", Name = "Евгения", YearDirth = "09.04.2000", BalansClient = 101000.87 });
            client.Add(new Client() { Sur = "Королева", Name = "Мария", YearDirth = "14.08.2003", BalansClient = 93907.08 });
            client.Add(new Client() { Sur = "Колхозов", Name = "Иван", YearDirth = "01.09.1951", BalansClient = 3500.64 });
            //sotrydnik.Insert(2, new Personal() { Sur = "Ермаков", Name = "Роман", YearDirth = "01.03.1971", BalansClient = 75090.64 });

            Console.WriteLine();
            foreach (var item in client)
            {
                Console.WriteLine($"Клиент:{item.Sur} {item.Name} Дата рождения:{item.YearDirth} Баланс:{item.BalansClient}");
            }

            static void Insert(Client Sur, Client Name, Client YearDirth, Client BalansClient)
            {
               
            }

        }

        
    }
}
