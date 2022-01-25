using System;
using System.Collections.Generic;
using System.Text;

namespace Burung_02
{
    class TelorRusak : Telur
    {
        public TelorRusak(double ukuran, string warnanya) : base (ukuran,warnanya)
        {
            Console.WriteLine("Malah rusak telornya");
        }
    }
}
