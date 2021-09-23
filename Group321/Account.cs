using System;
using System.Collections.Generic;
using System.Text;

namespace bank1
{
    class Account
    {
        private double _balance;
        private double _zadoljnost;
        private double _id;
        public static double _CreditStavka;
        public double Persent
        {
            get; set;
        }
        public string id
        {
            get; set;
        }
        public double CreditSher
        {
            get; set;
        }
        public static double creditSher = 5.7;
        public double Balance { get; set; }

        public double Zadoljnost { get; set; }

        
    }
    public class PersonalData
    {
        private string FIO;
        private string Adress;
        private string Balance;

        public PersonalData(string Name, string adress, string balance)
        {
            FIO = Name;
            Adress = adress;
            Balance = balance;

        }
    }
}
