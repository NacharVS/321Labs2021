using System;

namespace Bank
{
    class Employee : Account
    {
        public override double ProcentStavkaCredit { get => base.ProcentStavkaCredit; set => base.ProcentStavkaCredit = value; }
        public override double ProcentStavkaVklad { get => base.ProcentStavkaVklad; set => base.ProcentStavkaVklad = value; }
        public override PersonalData PD { get => base.PD; set => base.PD = value; }

        public Employee()
        {
            ProcentStavkaCredit = 4;
            ProcentStavkaVklad = 7;
        }

        public Employee(double balance, PersonalData pd)
        {
            balanceRubles = balance;
            balanceDollar = Math.Round(balance / 73.08, 2);
            ProcentStavkaCredit = 4;
            ProcentStavkaVklad = 7;
            PD = pd;
        }

        public Employee(double dollar, double rubles, PersonalData pd)
        {
            balanceDollar = dollar;
            balanceRubles = rubles;
            ProcentStavkaCredit = 4;
            ProcentStavkaVklad = 7;
            PD = pd;
        }

        public Employee(double balance, PersonalData pd, double credit, double vklad)
        {
            balanceRubles = balance;
            balanceDollar = Math.Round(balance / 73.08, 2);
            persondata = pd;
            Credit = credit;
            Vklad = vklad;
        }

        public override void Menu()
        {
            Console.WriteLine("\n1: Посмотреть баланс");
            Console.WriteLine("2: Пополнить баланс");
            Console.WriteLine("3: Перевести другому клиенту");
            Console.WriteLine("4: Взять кредит");
            Console.WriteLine("5: Снять деньги");
            Console.WriteLine("6: Открыть вклад");
            Console.WriteLine("7: Оплатить кредит");
            Console.WriteLine("8: Добавить аккаунт");
            Console.WriteLine("9: Удалить аккаунт");
            Console.WriteLine("10: Просмотреть все аккаунты");
            Console.WriteLine("11: Редактировать аккаунт");
            Console.WriteLine("12: Сменить аккаунт");
            Console.WriteLine("13: Выйти из приложения");
        }
    }
}
