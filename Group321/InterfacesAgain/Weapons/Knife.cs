using Group321.InterfacesAgain.WeaponsImpementatin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain.Weapons
{
    class Knife : IThrowableWeapon
    {
        public int ThrowDamage => 15;

        public int Damage => 6;

        public int Durability => throw new NotImplementedException();

        public void Hit()
        {
            var rnd = new Random().Next(10, 20);
            if (rnd % 2 == 0)
                Console.WriteLine($"{GetType().Name} kkkkkssssst!111 {Damage} ");
            else
                Throw();
        }

        public void Repair()
        {
            
        }

        private void Throw()
        {
            Console.WriteLine($"{GetType().Name} vvvvvssssst!111 {ThrowDamage} ");
        }
    }
}
