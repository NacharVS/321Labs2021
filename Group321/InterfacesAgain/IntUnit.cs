using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.InterfacesAgain
{
    public interface IntUnit
    {
        public string Name { get; set; }
        public double Hp { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double MoveSpeed { get; set; }
    }
}
