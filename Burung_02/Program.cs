using System;

namespace Burung_02
{
    class Program 
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Burung bi;
                Console.WriteLine("\n P = Piegon, O = Burung onta: ");
                char kunci = Char.ToUpper(Console.ReadKey().KeyChar);

                if (kunci == 'P') bi = new Merpati();
                else if (kunci == 'O') bi = new BurungOnta();
                else return;
                Console.Write("\nnumber of egg u lay?");
                if (!int.TryParse(Console.ReadLine(), out int banyakTelur)) return;

                //Telur[] tlrs = bi.EramTelur(banyakTelur);
                var tlrs = bi.EramTelur(banyakTelur);
                
                foreach (Telur telur in tlrs)
                {
                    Console.WriteLine(telur.Deskripsi);
                }

               // Telur t2 = new TelorRusak(12, "Redz");
              //  Console.WriteLine(t2.Deskripsi);


            }
        }
    }
}
