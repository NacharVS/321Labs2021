using System;
using System.Collections.Generic;
using System.Text;

namespace BankCore
{
    public class Employee : PersonalData
    {
        private string post;

        public Employee(string name, string surname, int age, long phone, string newPost) : base(name, surname, age, phone)
        {
            this.post = newPost;
        }

        public override void PersonalInfo()
        {
            Console.WriteLine($"{name} {surname} {age} {phone} {post}");
        }

        public override string ToString()
        {
            return $"{post}: {surname} {name}";
        }
    }
}
