using System;
using System.Collections.Generic;
using System.Text;
using GG.IWeapon;
using GG.ICharacters;

namespace GG.Characters
{
    class Archer : IMeaning
    {
        public int healf => 50;
        public int protection => 30;
        public int berserk => 20;
        public int speed => 10;

        public void Blow(IThrowableWeapon weapon)
        {
            weapon.Hit();
        }
        public void Mean()
        {
            Console.WriteLine($"{GetType().Name} has established");
        }

        public void rage()
        {
            Console.WriteLine("Shaman buffed Archer : rage ");
            Console.WriteLine($"Healf: {healf}");
            Console.WriteLine($"Berserk: {berserk + (berserk / 2)}");
            Console.WriteLine($"Protection: {protection / 2}");
            Console.WriteLine($"Speed: {speed}");
        }
    }
}
