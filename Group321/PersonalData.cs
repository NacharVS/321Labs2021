using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Personal
    {
        public string SurPersonal { get; set; }
        public string NamePersonal { get; set; }
        public string YearDirthPersonal { get; set; }
        public int WorkExperiencePersonal { get; set; }
        public string PostPersonal { get; set; }
    }
    class Client
    {
        //private int v;

        /*public Client(int v)
        {
            this.v = v;
        }*/

        public string SurClient { get; set; }
        public string NameClient { get; set; }
        public string YearDirthClient { get; set; }
        public double BalansClient { get; set; }
    }
    class PersonalData
    {
        public static void SotBanka()
        {
            List<Personal> sotrydnik = new List<Personal>();
            sotrydnik.Add(new Personal() { SurPersonal = "Иванов", NamePersonal = "Иван", YearDirthPersonal = "01.09.1987", WorkExperiencePersonal = 15, PostPersonal = "Администратор" });
            sotrydnik.Add(new Personal() { SurPersonal = "Куринов", NamePersonal = "Валентин", YearDirthPersonal = "04.10.1991", WorkExperiencePersonal = 9, PostPersonal = "Охранник" });
            sotrydnik.Add(new Personal() { SurPersonal = "Арбузова", NamePersonal = "Екатерина", YearDirthPersonal = "16.12.2000", WorkExperiencePersonal = 1, PostPersonal = "Операционист" });
            sotrydnik.Add(new Personal() { SurPersonal = "Утюгова", NamePersonal = "Севара", YearDirthPersonal = "18.02.1990", WorkExperiencePersonal = 7, PostPersonal = "Кредитный эксперт" });
            sotrydnik.Add(new Personal() { SurPersonal = "Морозов", NamePersonal = "Виктор", YearDirthPersonal = "01.01.1999", WorkExperiencePersonal = 3, PostPersonal = "Бухгалтер" });
            Console.WriteLine();
            foreach (var item in sotrydnik)
            {
                Console.WriteLine($"Сотрудник:{item.SurPersonal} {item.NamePersonal} Дата рождения:{item.YearDirthPersonal}  Стаж работы:{item.WorkExperiencePersonal} Должность:{item.PostPersonal}");
            }
        }


        public static void ClientBanka()
        {
            /*List<Client> client = new List<Client>();
            client.Add(new Client() { SurClient = "Павлов", NameClient = "Сергей", YearDirthClient = "01.07.1956", BalansClient = 30000.97 });
            client.Add(new Client() { SurClient = "Игорев", NameClient = "Алесандр", YearDirthClient = "13.06.1967", BalansClient = 19876.09 });
            client.Add(new Client() { SurClient = "Выхина", NameClient = "Евгения", YearDirthClient = "09.04.2000", BalansClient = 101000.87 });
            client.Add(new Client() { SurClient = "Королева", NameClient = "Мария", YearDirthClient = "14.08.2003", BalansClient = 93907.08 });
            client.Add(new Client() { SurClient = "Колхозов", NameClient = "Иван", YearDirthClient = "01.09.1951", BalansClient = 3500.64 });
            //sotrydnik.Insert(2, new Personal() { Sur = "Ермаков", Name = "Роман", YearDirth = "01.03.1971", BalansClient = 75090.64 });

            Console.WriteLine();
            foreach (var item in client)
            {
                Console.WriteLine($"Клиент:{item.SurClient} {item.NameClient} Дата рождения:{item.YearDirthClient} Баланс:{item.BalansClient}");
            }

            

        }*/

            public static void Insert(Client number1, string Familia, string Imei, string Rogdenie, double BalansShet)
            {
                List<Client> client = new List<Client>();
                client.Add(new Client() { SurClient = "Павлов", NameClient = "Сергей", YearDirthClient = "01.07.1956", BalansClient = 30000.97 });
                client.Add(new Client() { SurClient = "Игорев", NameClient = "Алесандр", YearDirthClient = "13.06.1967", BalansClient = 19876.09 });
                client.Add(new Client() { SurClient = "Выхина", NameClient = "Евгения", YearDirthClient = "09.04.2000", BalansClient = 101000.87 });
                client.Add(new Client() { SurClient = "Королева", NameClient = "Мария", YearDirthClient = "14.08.2003", BalansClient = 93907.08 });
                client.Add(new Client() { SurClient = "Колхозов", NameClient = "Иван", YearDirthClient = "01.09.1951", BalansClient = 3500.64 });
                //sotrydnik.Insert(2, new Personal() { Sur = "Ермаков", Name = "Роман", YearDirth = "01.03.1971", BalansClient = 75090.64 });

                Console.WriteLine();
                foreach (var item in client)
                {
                    Console.WriteLine($"Клиент:{item.SurClient} {item.NameClient} Дата рождения:{item.YearDirthClient} Баланс:{item.BalansClient}");
                }
                if (Familia != null && Imei != null && Rogdenie != null && BalansShet >= 0)
                {
                    number1.SurClient = Familia;
                    number1.NameClient = Imei;
                    number1.YearDirthClient = Rogdenie;
                    number1.BalansClient = BalansShet;
                    Console.WriteLine($"Клиент:{Familia} {Imei} Дата рождения:{Rogdenie} Баланс:{BalansShet}");
                }
                else
                {
                    Console.Write("Fill in the fields with values!");
                }


            }


        }
    }
}
