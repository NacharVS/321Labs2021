using System;
using System.Collections.Generic;
using System.Text;

namespace BankCore
{
    public class Client : PersonalData
    {
        private int idClient { get; set; }

        public Client(string name, string surname, int age, long phone) : base(name, surname, age, phone)
        {
            Random rnd = new Random();
            idClient = rnd.Next(1, 9999);
        }

        public override string ToString()
        {
            return $"{surname} {name}";
        }
    }
}
