using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace BankCore
{
    public class Test
    {
        List<Employee> employeList = new List<Employee>()
        {
            new Employee("Chuck", "Norris", 21, 800800, "Bodyguard"),
            new Employee("Stephen", "Hawking", 76, 800800, "Manager"),
            new Employee("Danil", "Karpov", 18, 800800, "Director")
        };
        
        //public Test()
        //{

        //}

        public void Start()
        {
            string msg = $"Start program\n...\n...\n...\n";

            foreach (char letter in msg)
            {
                Console.Write(letter);
                Thread.Sleep(50);
            }
            //Console.WriteLine();
            //Console.WriteLine("Our peronal:");

            //foreach (var emp in employeList)
            //{
            //    Console.WriteLine($"    {emp}");
            //}
            Console.WriteLine("You are welcome!");
            Console.WriteLine();
        }
    }
}
