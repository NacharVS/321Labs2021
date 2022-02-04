using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.InterfacesGarrison
{
    interface IShaman
    {
        int BaffDef { get; }
        int BaffAtt { get; }
        double Duration { get; }
        void BaffedAtt();
        void BaffedDef();
        void Salvation();
    }
}
