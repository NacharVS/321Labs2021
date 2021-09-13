using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Employee : Account
    {
        public static double Stavka = 10;
        public static double StavkaVklad { get => Stavka; set => Stavka = value; }
        public static double stavkaCred = 2;
        public static double StavkaCred { get => stavkaCred; set => stavkaCred = value; }
    }
}
