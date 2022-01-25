using System.Collections.Generic;

namespace Burung_02
{
    class Merpati : Burung
    {
        //public virtual Telur[] EramTelur(int banyakTelur)
        //public override Telur[] EramTelur(int banyakTelur)
        public override List<Telur> EramTelur(int banyakTelur)
        {
            //Telur[] xxx = new Telur[banyakTelur];
            List<Telur> tlrs = new List<Telur>();

            for (int i = 0; i < banyakTelur; i++)
            {
                //xxx[i] = new Telur(Burung.pengacak.NextDouble()*2+1, "Putih");
                tlrs.Add(new Telur(Burung.pengacak.NextDouble() * 2 + 1, "Putih"));

            } //end for loop

            return tlrs;
        } // END method
    } //END class
}