using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.InterfacesGarrison.Class
{
    class Shaman : IShaman
    {
        public double Duration => 20;

        public int BaffDef => 50;

        public int BaffAtt => 50;

        public void BaffedAtt()
        {
            Console.WriteLine($"Buff on berserk: + damage {BaffAtt}%, - defense {BaffDef}% and lasts {Duration} seconds");
        }

        public void BaffedDef()
        {
            Console.WriteLine($"Buff on stone skin: + defecse {BaffDef}% and lasts {Duration} seconds");
        }

        public void Salvation()
        {
            Console.WriteLine($"Resurrects a character with full resources and lasts {Duration} seconds");
        }

        public void ConclusionBuffonArcherAtt(ArcherUnit archer)
        {
            Console.WriteLine($"Buff on berserk on the {archer.GetType().Name}: + damage {BaffAtt}%, - defense {BaffDef}% and lasts {Duration} seconds");
        }

        public void ConclusionBuffonPyromancerAtt(Pyromancer pyro)
        {
            Console.WriteLine($"Buff on berserk on the {pyro.GetType().Name}: + damage {BaffAtt}%, - defense {BaffDef}% and lasts {Duration} seconds");
        }
        public void ConclusionBuffonArcherDef(ArcherUnit archer)
        {
            Console.WriteLine($"Buff on stone skin on the {archer.GetType().Name}: + defecse {BaffDef}% and lasts {Duration} seconds");
        }
        public void ConclusionBuffonPyromancerDef(Pyromancer pyro)
        {
            Console.WriteLine($"Buff on stone skin on the {pyro.GetType().Name}: + defecse {BaffDef}% and lasts {Duration} seconds");
        }
    }
}
