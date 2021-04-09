using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=== Aplikasi Penghitung Kalori dan AKG Harian ===");

            pengguna p = new pengguna();
            p.dataPengguna();

            kalori k = new kalori(p.jenisKelamin, p.umur, p.tinggiBadan, p.beratBadan, p.olahraga, 0, 0);
            k.hitungKalori();

            angkaKecukupanGizi a = new angkaKecukupanGizi(k.kal);
            a.hitungAKG();

            apel A = new apel(k.kal);
            A.kandungan();
            jeruk J = new jeruk(k.kal);
            J.kandungan();
            pisang P = new pisang(k.kal);
            P.kandungan();

            var karbo = a.karboAKG.ToString("#.##");
            var prot  = a.protAKG.ToString("#.##");
            var lem = a.lemAKG.ToString("#.##");
            var ape = A.Apel.ToString("#.##");
            var jer = J.Jeruk.ToString("#.##");
            var pis = P.Pisang.ToString("#.##");

            Console.WriteLine("\n====================================================");
            Console.WriteLine("Kebutuhan kalori harian Anda adalah " + k.kal + " kkal");
            Console.WriteLine("\nAKG harian Anda :");
            Console.WriteLine("Karbohidrat\t:\t" + karbo + " gram");
            Console.WriteLine("Protein\t\t:\t" + prot + " gram");
            Console.WriteLine("Lemak\t\t:\t" + lem + " gram");
            Console.WriteLine("\nBuah yang dapat dikonsumsi untuk memenuhi seluruh kebutuhan kalori harian Anda adalah :");
            Console.WriteLine("Apel (58 kkal)\t  :\t" + ape + " gram");
            Console.WriteLine("Jeruk (45 kkal)\t  :\t" + jer + " gram");
            Console.WriteLine("Pisang (109 kkal) :\t" + pis + " gram");
            Console.WriteLine("====================================================");
        }
    }
}
