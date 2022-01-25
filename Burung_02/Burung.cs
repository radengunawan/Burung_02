using System;
using System.Collections.Generic;
using System.Text;

namespace Burung_02
{
    class Burung
    {
        public static Random pengacak = new Random();

     
        public virtual Telur[] EramTelur(int banyakTelur)
        {
            //throw new NotImplementedException();
            Console.Error.WriteLine("Bird.Layeggs should never get called");
            return new Telur[0];
        }
    }
}
