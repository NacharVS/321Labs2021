using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Operations
    {
        public static void ShowEmployee(Employee employee)
        {
            Console.WriteLine($"Вашe ФИО: {employee.FullName}, " + $"ваш ID: {employee.idAccount}, "+ $"ваш номер телефона: {employee.Telephone}, " + $"и ваше состояние: { employee.Salary}");
        }

        public static void ShowClient(Client client)
        {
            Console.WriteLine($"Ваше ФИО: {client.FullName}, " + $"ваш ID: {client.idAccount}, " + $"ваш номер телефона: {client.Telephone}, " + $"баланс вашего счета {client.Ballance}");
        }
    }
}
