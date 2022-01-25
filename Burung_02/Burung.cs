using System;
using System.Collections.Generic;
using System.Text;

namespace Burung_02
{
    class Burung
    {
        public static Random pengacak = new Random();


        //public virtual Telur[] EramTelur(int banyakTelur)
        public virtual List<Telur> EramTelur(int banyakTelur)
        {
            //throw new NotImplementedException();
            List<Telur> x = new List<Telur>();
            x.Add(null);
            Console.Error.WriteLine("Bird.Layeggs should never get called");
            
            return x;
        }
    }
}
