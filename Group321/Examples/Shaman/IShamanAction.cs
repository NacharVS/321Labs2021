using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense.Examples 
{
    interface IShamanAction
    {
        int BuffDamage { get; }

        int BuffHealth { get;  }

        int BuffDefence { get; }

        int Defence { get; }

        int Duration { get;  }

        void BerserkBuff();

        void StoneSkin();

        void Salvation();

    }
}
