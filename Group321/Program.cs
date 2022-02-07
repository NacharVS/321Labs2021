using System;
using GG.House;

namespace GG
{
    class Program
    {
        static void Main(string[] args)
        {
            CharactersHouse archer1 = new CharactersHouse();
            var Lucius = archer1.MakeArcher();
            Lucius.Mean();

            CharactersHouse shaman1 = new CharactersHouse();
            var Astoria = shaman1.MakeShaman();
            Astoria.Mean();
            Astoria.rage(Lucius);

            GarrisonHouse ph1 = new GarrisonHouse();
        }
    }
}
