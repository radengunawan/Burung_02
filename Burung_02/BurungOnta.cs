namespace Burung_02
{
    class BurungOnta : Burung
    {
        //public virtual Telur[] EramTelur(int banyakTelur)
        public override Telur[] EramTelur(int banyakTelur)
        {
            Telur[] tlor = new Telur[banyakTelur];
            for (int i = 0; i < banyakTelur; i++)
            {
                tlor[i] = new Telur(Burung.pengacak.NextDouble() +12, "Speckled");
                 // tlor[i] = new Telur(Burung.pengacak.NextDouble()  + 12, "Speckled");
        }

        return tlor;
        }//end method
    }
}