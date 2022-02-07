using System;
using System.Collections.Generic;
using System.Text;
using GG.ICharacters;

namespace GG.Characters
{
    class Shaman : IMeaning
    {
        public int healf => 100;

        public int protection => 50;

        public int berserk => 40;

        public int speed => 15;

        public void Mean()
        {
            Console.WriteLine($"{GetType().Name} has established");
        }

        public void Fury()
        {
            Console.WriteLine("Shaman buffed Shaman : Fury ");
            Console.WriteLine($"Healf: {healf}");
            Console.WriteLine($"Berserk: {berserk + (berserk / 2)}");
            Console.WriteLine($"Protection: {protection / 2}");
            Console.WriteLine($"Speed: {speed}");
        }

        public void rage()
        {
            throw new NotImplementedException();
        }

        public void rage(IMeaning m)
        {
            m.rage();
        }
    }
}
