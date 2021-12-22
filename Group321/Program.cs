using System;
using System.Collections.Generic;

namespace KrasnovExsam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> lst = new List<Student>()
            {
                new Student("Иванов", 5, 5, 5, 4, 3),
                new Student("Краснов", 5, 5, 3, 4, 3),
                new Student("Петров", 5, 2, 2, 5, 3),
                new Student("Сергеев", 5, 5, 2, 4, 3),
                new Student("Хлыбов", 2, 2, 2, 2, 3)
            };
            GetStudents(lst);
        }

        static void GetStudents(List<Student> students)
        {
            Console.WriteLine("Введит значение средней переменной оценки студента : ");
            double Srednyia = Convert.ToDouble(Console.ReadLine());
            foreach (var item in students)
            {
                if (item.SrednayOcenka >= Srednyia)
                {
                    Console.WriteLine("Средняя оценка более" + " " + Srednyia +  " у студентов : " + item.FIO );
                }
            }
        }
    }

    public class Student
    {
        public string FIO;
        int Russion;
        int Ximico;
        int Math;
        int Phys;
        int Fizika;
       public double SrednayOcenka;

        public Student(string fio, int Russion, int Ximico, int Math, int Phys, int Fizika)
        {
            this.Russion = Russion;
            this.Ximico = Ximico;
            this.Math = Math;
            this.Phys = Phys;
            this.Fizika = Fizika;
            FIO = fio;
            GetSred();
        }

        public void GetSred()
        {
            SrednayOcenka = (Russion + Ximico + Math + Phys + Fizika) / 5;
        }

    }
}
