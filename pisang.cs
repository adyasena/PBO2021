namespace oop
{
    public class pisang : buah
    {
        public pisang(double kal) : base(kal)
        {
            this.kal = kal;
        }
        
        private double PISANG;
        public override void kandungan()
        {
            PISANG = kal / 109 * 100;
        }

        public double Pisang
        {
            get
            {
                return PISANG;
            }
            set
            {
                PISANG = value;
            }
        }
    }
}