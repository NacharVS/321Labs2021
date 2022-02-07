using System;
using System.Collections.Generic;
using System.Text;
using _0302.InterfaceWeapon;
using _0302.House;
using _0302.Unit;

namespace _0302.InterfaceUnit
{
    interface Parametrs : IThrowableWeapon
    {
        int healf { get; }  
        int berserk { get; }
        int defense { get; }
        int speed { get; }
        void Par();
        void Atack();
        void Add(Archer ar);

        public void Fury()
        {
            Console.WriteLine($"Shaman buffed { GetType().Name} : Fury ");
            Console.WriteLine($"{ GetType().Name} and parametrs ");
            Console.WriteLine($"Healf: {healf}");
            Console.WriteLine($"Berserk: {berserk + (berserk / 2)}");
            Console.WriteLine($"Defense: {defense / 2}");
            Console.WriteLine($"Speed: {speed}");
        }
        public void StoneSkin()
        {
            Console.WriteLine($"Shaman buffed { GetType().Name} : Stone skin ");
            Console.WriteLine($"{ GetType().Name} and parametrs: ");
            Console.WriteLine($"Healf: {healf + healf / 100 * 20}");
            Console.WriteLine($"Berserk: {berserk}");
            Console.WriteLine($"Defense: {defense + defense / 100 * 30}");
            Console.WriteLine($"Speed: {speed / 100 * 40}");
        }
        public void Salvation()
        {
            Console.WriteLine($"Shaman buffed { GetType().Name} : Salvation ");
            Console.WriteLine($"{ GetType().Name} and parametrs ");
            Console.WriteLine($"Healf: {healf * 2}");
            Console.WriteLine($"Berserk: {berserk * 2}");
            Console.WriteLine($"Defense: {defense * 2}");
            Console.WriteLine($"Speed: {speed * 2}");
        }
    }
}
