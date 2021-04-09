namespace oop
{
    public class apel : buah
    {
        public apel(double kal) : base(kal)
        {
            this.kal = kal;
        }

        private double APEL;
        public override void kandungan()
        {
            APEL = kal / 58 * 100;
        }

        public double Apel
        {
            get
            {
                return APEL;
            }
            set
            {
                APEL = value;
            }
        }
    }
}