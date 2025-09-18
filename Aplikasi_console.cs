using System;

namespace HewanPeliharaanApp
{
    class Hewan
    {
        // Encapsulation (Data Hiding dengan private field)
        private string nama;
        private string jenis;
        private int umur;

        // Constructor
        public Hewan(string nama, string jenis, int umur)
        {
            this.nama = nama;
            this.jenis = jenis;
            this.umur = umur;
        }

        // Properties (getter & setter)
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Jenis
        {
            get { return jenis; }
            set { jenis = value; }
        }

        public int Umur
        {
            get { return umur; }
            set { umur = value; }
        }

        // Method
        public void Suara()
        {
            if (jenis.ToLower() == "kucing")
                Console.WriteLine($"{nama} Mengeong");
            else if (jenis.ToLower() == "anjing")
                Console.WriteLine($"{nama} Menggonggong");
            else
                Console.WriteLine($"{nama} bersuara...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Object
            Hewan kucing = new Hewan("Tom", "Kucing", 3);
            Hewan anjing = new Hewan("Spike", "Anjing", 5);

            // Menampilkan data
            Console.WriteLine("=== Hewan Peliharaan ===");
            Console.WriteLine($"{kucing.Nama} adalah {kucing.Jenis}, berumur {kucing.Umur} tahun");
            kucing.Suara();

            Console.WriteLine($"{anjing.Nama} adalah {anjing.Jenis}, berumur {anjing.Umur} tahun");
            anjing.Suara();

            Console.ReadLine();
        }
    }
}
