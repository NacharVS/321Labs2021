using System;
using System.Collections.Generic;
using System.Text;

namespace BankCore
{
    public abstract class PersonalData : IPersonalData
    {
        protected string name, surname;
        protected int age;
        protected long phone;

        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                age = value;
            }
        }

        public long Phone
        {
            get => phone;
            set
            {
                phone = value;
            }
        }

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

        public override string ToString()
        {
            return $"{surname}";
        }

        public void PersonalInfoTest()
        {
            throw new NotImplementedException();
        }
    }
}
