using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Klient : Account
    {
        public static double Stavka = 5;
        public static double StavkaVklad { get => Stavka; set => Stavka = value; }
        public static double stavkaCred = 5;
        public static double StavkaCred { get => stavkaCred; set => stavkaCred = value; }
    }
}
