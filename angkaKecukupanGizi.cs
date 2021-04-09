namespace oop
{
    public class angkaKecukupanGizi : kalori, IAKG
    {
        public double karboAKG, protAKG, lemAKG;
        public angkaKecukupanGizi(double kal)
        {
            this.kal = kal;
        }
        public angkaKecukupanGizi()
        {   
        }

        public void hitungAKG()
        {
            karboAKG = kal * 0.65 / 4;
            protAKG = kal * 0.15 / 4;
            lemAKG = kal * 0.20 / 9;
        }
    }
}