using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Personal
    {
        public int ID_Personal { get; set; }
        public string SurPersonal { get; set; }
        public string NamePersonal { get; set; }
        public string YearDirthPersonal { get; set; }
        public int WorkExperiencePersonal { get; set; }
        public string PostPersonal { get; set; }
    }
    class Client
    {
        public int ID_Client { get; set; }
        public string SurClient { get; set; }
        public string NameClient { get; set; }
        public string YearDirthClient { get; set; }
        public double BalansClient { get; set; }
    }

    class PersonalData
    {

        public static void InsertPersonal(Personal personal1,int idpersonal, string FamiliaPersonal, string ImeiPersonal, string RogdeniePersonal, int StagPersonal, string PositionPersonal)
        {
            List<Personal> sotrydnik = new List<Personal>();
            sotrydnik.Add(new Personal() { ID_Personal = 1, SurPersonal = "Иванов", NamePersonal = "Иван", YearDirthPersonal = "01.09.1987", WorkExperiencePersonal = 15, PostPersonal = "Администратор" });
            sotrydnik.Add(new Personal() { ID_Personal = 2, SurPersonal = "Куринов", NamePersonal = "Валентин", YearDirthPersonal = "04.10.1991", WorkExperiencePersonal = 9, PostPersonal = "Охранник" });
            sotrydnik.Add(new Personal() { ID_Personal = 3, SurPersonal = "Арбузова", NamePersonal = "Екатерина", YearDirthPersonal = "16.12.2000", WorkExperiencePersonal = 1, PostPersonal = "Операционист" });
            sotrydnik.Add(new Personal() { ID_Personal = 4, SurPersonal = "Утюгова", NamePersonal = "Севара", YearDirthPersonal = "18.02.1990", WorkExperiencePersonal = 7, PostPersonal = "Кредитный эксперт" });
            sotrydnik.Add(new Personal() { ID_Personal = 5, SurPersonal = "Морозов", NamePersonal = "Виктор", YearDirthPersonal = "01.01.1999", WorkExperiencePersonal = 3, PostPersonal = "Бухгалтер" });
            Console.WriteLine();
            foreach (var item in sotrydnik)
            {
                Console.WriteLine($"Номер: {item.ID_Personal} Сотрудник:{item.SurPersonal} {item.NamePersonal} Дата рождения:{item.YearDirthPersonal}  Стаж работы:{item.WorkExperiencePersonal} Должность:{item.PostPersonal}");
            }
            if (FamiliaPersonal != null && ImeiPersonal != null && RogdeniePersonal != null && PositionPersonal != null && StagPersonal >= 0 && idpersonal > 0)
            {
                personal1.ID_Personal = idpersonal;
                personal1.SurPersonal = FamiliaPersonal;
                personal1.NamePersonal = ImeiPersonal;
                personal1.YearDirthPersonal = RogdeniePersonal;
                personal1.WorkExperiencePersonal = StagPersonal;
                personal1.PostPersonal = PositionPersonal;
                Console.WriteLine($"Номер: {idpersonal} Сотрудник:{FamiliaPersonal} {ImeiPersonal} Дата рождения:{RogdeniePersonal} Стаж работы:{StagPersonal} Должность:{PositionPersonal}");
            }
            else
            {
                Console.Write("Fill in the fields with values!");
            }
        }

        /*public static void RemovePersonal(int idpersonal)
        {
            List<Personal> sotrydnik = new List<Personal>();
            sotrydnik.Add(new Personal() { ID_Personal = 1, SurPersonal = "Иванов", NamePersonal = "Иван", YearDirthPersonal = "01.09.1987", WorkExperiencePersonal = 15, PostPersonal = "Администратор" });
            sotrydnik.Add(new Personal() { ID_Personal = 2, SurPersonal = "Куринов", NamePersonal = "Валентин", YearDirthPersonal = "04.10.1991", WorkExperiencePersonal = 9, PostPersonal = "Охранник" });
            sotrydnik.Add(new Personal() { ID_Personal = 3, SurPersonal = "Арбузова", NamePersonal = "Екатерина", YearDirthPersonal = "16.12.2000", WorkExperiencePersonal = 1, PostPersonal = "Операционист" });
            sotrydnik.Add(new Personal() { ID_Personal = 4, SurPersonal = "Утюгова", NamePersonal = "Севара", YearDirthPersonal = "18.02.1990", WorkExperiencePersonal = 7, PostPersonal = "Кредитный эксперт" });
            sotrydnik.Add(new Personal() { ID_Personal = 5, SurPersonal = "Морозов", NamePersonal = "Виктор", YearDirthPersonal = "01.01.1999", WorkExperiencePersonal = 3, PostPersonal = "Бухгалтер" });
            Console.WriteLine();
            foreach (var item in sotrydnik)
            {
                Console.WriteLine($"Номер: {item.ID_Personal} Сотрудник:{item.SurPersonal} {item.NamePersonal} Дата рождения:{item.YearDirthPersonal}  Стаж работы:{item.WorkExperiencePersonal} Должность:{item.PostPersonal}");
            }
            if (ID_Personal = idpersonal)
            {
                
                //Console.WriteLine($"Номер: {idpersonal} Сотрудник:{FamiliaPersonal} {ImeiPersonal} Дата рождения:{RogdeniePersonal} Стаж работы:{StagPersonal} Должность:{PositionPersonal}");
            }
            else
            {
                Console.Write("Fill in the fields with values!");
            }
        }*/
        public static void InsertClient(Client client1, string FamiliaClient, string ImeiClient, string RogdenieClient, double BalansShet)
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
            if (FamiliaClient != null && ImeiClient != null && RogdenieClient != null && BalansShet >= 0)
            {
                client1.SurClient = FamiliaClient;
                client1.NameClient = ImeiClient;
                client1.YearDirthClient = RogdenieClient;
                client1.BalansClient = BalansShet;
                Console.WriteLine($"Клиент:{FamiliaClient} {ImeiClient} Дата рождения:{RogdenieClient} Баланс:{BalansShet}");
            }
            else
            {
                Console.Write("Fill in the fields with values!");
            }
        }       
    }
}
