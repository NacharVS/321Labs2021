using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практика_интерфейсы.WeaponsImpementatin;

namespace Практика_интерфейсы.Weapons
{
    class Knife : IThrowableWeapon, IMleeWeapon
    {
        public int ThrowDamage => 15;

        public int Damage => 6;

        public int Durability => throw new NotImplementedException();

        public void Hit()
        {
            Throw();

        }

        void IMleeWeapon.Hit()
        {
            Console.WriteLine($"{GetType().Name} kkkkkssssst!111 {Damage} ");
        }

        public void Repair()
        {
            Console.WriteLine("Knife repaired");
        }

        private void Throw()
        {
            Console.WriteLine($"{GetType().Name} vvvvvssssst!111 {ThrowDamage} ");
        }
    }
}
