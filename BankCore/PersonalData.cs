using System;
using System.Collections.Generic;
using System.Text;

namespace BankCore
{
    public class PersonalData
    {
        protected string name, surname;
        protected int age;
        protected long phone;

        public PersonalData(string name, string surname, int age, long phone)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.phone = phone;
        }

        public virtual void PersonalInfo()
        {
            Console.WriteLine($"Name: {name} {surname},  Age: {age},  Phone: {phone}");
        }
    }
}
