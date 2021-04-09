namespace oop
{
    public class jeruk : buah
    {
        public jeruk(double kal) : base(kal)
        {
            this.kal = kal;
        }

        private double JERUK;
        public override void kandungan()
        {
            JERUK = kal / 45 * 100;
        }

        public double Jeruk
        {
            get
            {
                return JERUK;
            }
            set
            {
                JERUK = value;
            }
        }
    }
}