namespace oop
{
    public class kalori : pengguna, IKalori
    {
        public double bmr, kal;

        public kalori(string jenisKelamin, int umur, int tinggiBadan, int beratBadan, int olahraga, double bmr, double kal)
        {
            this.jenisKelamin = jenisKelamin;
            this.umur = umur;
            this.tinggiBadan = tinggiBadan;
            this.beratBadan = beratBadan;
            this.olahraga = olahraga;
            this.bmr = bmr;
            this.kal = kal;
        }
        
        public kalori()
        {
        }

        public void hitungKalori()
        {
            if (jenisKelamin.ToLower() == "pria")
                bmr = 66.5 + (beratBadan * 13.7) + (tinggiBadan * 5) - (umur * 6.8);
            
            if (jenisKelamin.ToLower() == "wanita")
                bmr = 655 + (beratBadan * 9.6) + (tinggiBadan * 1.8) - (umur * 4.7);

            if (olahraga == 1)
                kal = bmr * 1.2;
            
            if (olahraga == 2)
                kal = bmr * 1.375;
            
            if (olahraga == 3)
                kal = bmr * 1.55;
            
            if (olahraga == 4)
                kal = bmr * 1.725;
            
            if (olahraga == 5)
                kal = bmr * 1.9;
            
        }
    }
}