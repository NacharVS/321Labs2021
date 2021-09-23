using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    /*public struct Sotrydnik
    {

        public string Sur { get; set; }
        public string Name { get; set; }
        public int YearDirth { get; set; }
        public int WorkExperience { get; set; }
        public string Post { get; set; }

        public void Create(string line)
        {
            string[] arr = line.Split(';');
            Sur = arr[0];
            Name = arr[1];
            YearDirth = int.Parse(arr[2]);
            WorkExperience = int.Parse(arr[3]);
            Post = arr[4];

        }

        public override string ToString()
        {
            return $"{Sur};{Name};{YearDirth.ToString()};{WorkExperience.ToString()};{Post}";
        }
    }*/

    class Personal
    {
        public string Sur { get; set; }
        public string Name { get; set; }
        public string YearDirth { get; set; }
        public int WorkExperience { get; set; }
        public string Post { get; set; }

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
            List<Personal> sotrydnik = new List<Personal>();
            sotrydnik.Add(new Personal() { Sur = "Павлов", Name = "Сергей", YearDirth = "01.07.1956", BalansClient = 30000.97 });
            sotrydnik.Add(new Personal() { Sur = "Игорев", Name = "Алесандр", YearDirth = "13.06.1967", BalansClient = 19876.09 });
            sotrydnik.Add(new Personal() { Sur = "Выхина", Name = "Евгения", YearDirth = "09.04.2000", BalansClient = 101000.87 });
            sotrydnik.Add(new Personal() { Sur = "Королева", Name = "Мария", YearDirth = "14.08.2003", BalansClient = 93907.08 });
            sotrydnik.Add(new Personal() { Sur = "Колхозов", Name = "Иван", YearDirth = "01.09.1951", BalansClient = 3500.64 });
            Console.WriteLine();
            foreach (var item in sotrydnik)
            {
                Console.WriteLine($"Клиент:{item.Sur} {item.Name} Дата рождения:{item.YearDirth} Баланс:{item.BalansClient}");
            }
        }
    }
}
