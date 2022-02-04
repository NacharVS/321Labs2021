using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense.Examples
{
    interface IBardAction
    {
        string Music { get; }

        double MusicDuration { get;  }

        void Play();
    }
}
