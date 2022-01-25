namespace Burung_02
{
     class Telur
    {
        public double Size { get;  private set; }
        public string Warna{ get; private set; }

        public Telur (double ukuran, string warnanya)
        {
            this.Size = ukuran;
            this.Warna = warnanya;
        }

        public string Deskripsi {
            get { return $"A {this.Size:0.0}cm, {this.Warna} egg"; }

             }
    }
}