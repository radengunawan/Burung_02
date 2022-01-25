using System;
using System.Collections.Generic;
using System.Text;

namespace Burung_02
{
    class TelorRusak : Telur
    {
        public TelorRusak(string warnanya) : base (0,$"broken {warnanya}")
        {
           Console.WriteLine("Malah rusak telornya");
           
        }
    }
}
