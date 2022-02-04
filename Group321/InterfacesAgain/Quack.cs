using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
   public  class Quack : IUnits
    {
        public Quack(string name, double damage, double armor, double hp, double run)
        {
            Name = name;
            Damage = damage;
            Armor = armor;
            Hp = hp;
            Run = run;
        }

        public Quack()
        {

        }

        public string Name { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double Hp { get; set; }
        public double Run { get; set; }

        //Шаман который накладывает бафы (Берсерк +50% урон,-50% защита)(Каменная кожа +30% защита, -40% здоровье)(Спасение)
        public void ALLBAFSS()
        {
            Console.WriteLine("У вас все баффы,вы жёсткий!!");
            BERSERK();
            STONESKIN();       
        }
        public void BERSERK()
        {
            Console.WriteLine("Вас баффнул шаман,БЕРСЕРК Даёт вам: + 50% урона, - 50% защита ");
        }
        
        public void BERSERK(IUnits units)
        {
            units.Damage = ((units.Damage/100) * 50) + units.Damage;
            units.Armor = (units.Armor * 0.5);
            Console.WriteLine("Вас баффнул шаман,БЕРСЕРК Даёт вам: + 50% урона, - 50% защита ");
        }
        public void STONESKIN()
        {
            Console.WriteLine("Вас баффнул шаман,КАМЕННАЯ КОЖА Даёт вам: + 30% защита, - 40% здоровье ");
        }
        public void STONESKIN(IUnits units)
        {
            units.Armor = ((units.Armor / 100) * 30) + units.Armor;
            units.Hp = (units.Hp * 0.4);
            Console.WriteLine("Вас баффнул шаман,КАМЕННАЯ КОЖА Даёт вам: + 30% защита, - 40% здоровье ");
        }
        public void SPASENIE()
        {
            Console.WriteLine("Я НЕ УМРУ,Я БУДУ ЖИТЬ ВЕЧНО!!!" +
                "ВАС ВОСКРЕСИЛИ");
        }
        public void SPASENIE(IUnits units)
        {
            units.Hp += units.Hp;
            Console.WriteLine("Я НЕ УМРУ,Я БУДУ ЖИТЬ ВЕЧНО!!!" +
                "ВАС ВОСКРЕСИЛИ");
        }

    }
}
