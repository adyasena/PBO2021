using System;

namespace oop
{
    public class pengguna
    {
        public string jenisKelamin;
        public int umur, tinggiBadan, beratBadan, olahraga;

        public void dataPengguna()
        {
            Console.Write("Pria atau wanita? ");
            jenisKelamin = Console.ReadLine();
            Console.Write("Umur? ");
            umur = int.Parse(Console.ReadLine());
            Console.Write("Tinggi badan? ");
            tinggiBadan = int.Parse(Console.ReadLine());
            Console.Write("Berat badan? ");
            beratBadan = int.Parse(Console.ReadLine());
            Console.WriteLine("(1) Tidak pernah");
            Console.WriteLine("(2) Jarang (1-3 hari)");
            Console.WriteLine("(3) Kadang (3-5 hari)");
            Console.WriteLine("(4) Sering (6-7 hari)");
            Console.WriteLine("(5) Selalu olahraga/aktivitas fisik berat");
            Console.WriteLine("Seberapa sering Anda beraktivitas fisik atau olahraga dalam seminggu?");
            Console.Write("Pilih angka 1-5 : ");
            olahraga = int.Parse(Console.ReadLine());
        }
    }
}