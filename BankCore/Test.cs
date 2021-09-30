using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace BankCore
{
    public class Test
    {
        public void Start()
        {
            string msg = $"Start program\n...\n...\n...\n";

            foreach (char letter in msg)
            {
                Console.Write(letter);
                Thread.Sleep(50);
            }
            Console.WriteLine();
        }
    }
}
