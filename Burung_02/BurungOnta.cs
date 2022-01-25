using System.Collections.Generic;

namespace Burung_02
{
    class BurungOnta : Burung
    {
        //public virtual Telur[] EramTelur(int banyakTelur)
        public override List<Telur> EramTelur(int banyakTelur)
        {
            //Telur[] tlor = new Telur[banyakTelur];
            List<Telur> tlor = new List<Telur>();
            
            for (int i = 0; i < banyakTelur; i++)
            {
                //tlor[i] = new Telur(Burung.pengacak.NextDouble() +12, "Speckled");
                tlor.Add(new Telur(Burung.pengacak.NextDouble() + 12, "Speckled"));
        }

        return tlor;
        }//end method
    }
}