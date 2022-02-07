using System;
using System.Collections.Generic;
using System.Text;
using Group321.InterfacesAgain.Units;

namespace Group321.InterfacesAgain.WeaponsImpementatin
{
    public interface IGarison
    {

        string Name { get; set; }
        double Damage { get; set; }
        double Armor { get; set; }
        double Hp { get; set; }
        double Run { get; set; }

        public void Archer();
        public void Soldier();
        public void PhantomAssasin();
        public void Svinger();
    }
}
