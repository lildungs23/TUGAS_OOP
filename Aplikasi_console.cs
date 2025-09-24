using System;
using System.Collections.Generic;

// Parent class Hewan
class Hewan
{
    // Encapsulation (field private dengan properti)
    private string nama;
    private string jenis;
    private int umur;

    public string Nama { get => nama; set => nama = value; }
    public string Jenis { get => jenis; set => jenis = value; }
    public int Umur { get => umur; set => umur = value; }

    // Constructor 1 (lengkap)
    public Hewan (string nama, string jenis, int umur)
    {
        Nama = nama;
        Jenis = jenis;
        Umur = umur;
    }

    // Constructor 2 (hanya nama, default jenis & umur)
    public Hewan (string nama)
    {
        Nama = nama;
        Jenis = "Tidak diketahui";
        Umur = 0;
    }

    // Constructor 3 (tanpa parameter)
    public Hewan()
    {
        Nama = "Anonim";
        Jenis = "Umum";
        Umur = 1;
    }

    // Method virtual (bisa dioverride)
    public virtual void Suara()
    {
        Console.WriteLine($"{Nama} mengeluarkan suara umum...");
    }

    // Overloading method Info()
    public void Info()
    {
        Console.WriteLine($"Nama: {Nama}, Jenis: {Jenis}, Umur: {Umur} tahun");
    }

    public void Info(string prefix)
    {
        Console.WriteLine($"{prefix} - Nama: {Nama}, Jenis: {Jenis}, Umur: {Umur} tahun");
    }
}

// Class Kucing turunan Hewan
class Kucing : Hewan
{
    public string WarnaBulu { get; set; }

    // Constructor memanggil parent
    public Kucing(string nama, int umur, string warnaBulu)
        : base(nama, "Kucing", umur)
    {
        WarnaBulu = warnaBulu;
    }

    public override void Suara()
    {
        Console.WriteLine($"{Nama} bersuara: Meow~");
    }
}

// Class Anjing turunan Hewan
class Anjing : Hewan
{
    public string Ras { get; set; }

    public Anjing(string nama, int umur, string ras)
        : base(nama, "Anjing", umur)
    {
        Ras = ras;
    }

    public override void Suara()
    {
        Console.WriteLine($"{Nama} bersuara: Guk! Guk!");
    }
}

// Composition: Kandang berisi banyak Hewan
class Kelompok
{
    public string NamaKelompok { get; set; }
    private List<Hewan> daftarHewan = new List<Hewan>();

    public Kelompok(string namaKelompok)
    {
        NamaKelompok = namaKelompok;
    }

    public void TambahHewan(Hewan h)
    {
        daftarHewan.Add(h);
        Console.WriteLine($"{h.Nama} ditambahkan ke {NamaKelompok}");
    }

    public void TampilkanHewan()
    {
        Console.WriteLine($"\nIsi kandang {NamaKelompok}:");
        foreach (var h in daftarHewan)
        {
            h.Info();
            h.Suara(); // polymorphism: suara tergantung jenis hewan
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // Buat kandang
        Kelompok Kelompok1 = new Kelompok("Mamalia");

        // Buat hewan (constructor overloading)
        Hewan h1 = new Hewan("Gajah", "Mamalia", 10);
        Kucing k1 = new Kucing("Sumbul", 2, "Putih");
        Anjing a1 = new Anjing("Dexter", 3, "Bulldog");
        Hewan h2 = new Hewan("Burung");
        Hewan h3 = new Hewan("");

        // Tambahkan ke kandang
        Kelompok1.TambahHewan(h1);
        Kelompok1.TambahHewan(k1);
        Kelompok1.TambahHewan(a1);
        Kelompok1.TambahHewan(h2);
        Kelompok1.TambahHewan(h3);

        // Tampilkan isi kandang
        Kelompok1.TampilkanHewan();
    }
}

