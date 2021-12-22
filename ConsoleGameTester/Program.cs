using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCore;
using GameCore.Classes;

namespace ConsoleGameTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Peasant peasant = new Peasant("Данил", 10, 10, 10);
            peasant.GetBiography();
            peasant.GoWork();
            peasant.GoEat();

            //Knight knight = new Knight("Дияр", 20, 15, 12);
            //knight.GetBiography();
            //knight.GoWork();
            //knight.GoEat();

            Knight knight = new Knight("Дияр", "Бюджетный");
            Console.WriteLine($"{knight.Nickname}");
            Console.ReadLine();
        }
    }
}
