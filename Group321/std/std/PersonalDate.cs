using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace std
{
    class Date
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public double Mark { get; set; }

    }
    class PersonalDate
    {
        public void Insert()
        {
            List<Date> Student = new List<Date>();
            Student.Add(new Date() { First_Name = "Митрофан", Last_Name = "Дмитриев", Mark = 4.45 });
            Student.Add(new Date() { First_Name = "Александр", Last_Name = "Грей", Mark = 5.00 });
            Student.Add(new Date() { First_Name = "Виктория", Last_Name = "Петрова", Mark = 3.55 });
            Student.Add(new Date() { First_Name = "Пантелеймон", Last_Name = "Великий", Mark = 4.30 });
            Student.Add(new Date() { First_Name = "Лиза", Last_Name = "Арбузова", Mark = 2.11 });
            Student.Add(new Date() { First_Name = "Астория", Last_Name = "Александровна", Mark = 4.55 });
            Console.WriteLine();


            foreach (var item in Student)
            {
                Console.WriteLine($" Имя: {item.First_Name} Фамилия: {item.Last_Name} Оценка: {item.Mark}");
            }
            var str = from atr in Student
                      where atr.Mark > 3
                      select atr;
            foreach (Date atr in str)
                Console.WriteLine($"Имя:{atr.First_Name} Фамилия:{atr.Last_Name} - Оценка:{atr.Mark}");

        }


    }
}
